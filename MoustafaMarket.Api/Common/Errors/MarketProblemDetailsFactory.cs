﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace MoustafaMarket.Api.Common.Errors
{
    public class MarketProblemDetailsFactory : ProblemDetailsFactory
    {
        private readonly ApiBehaviorOptions _options;
        private readonly Action<ProblemDetailsContext>? _configure;

        public MarketProblemDetailsFactory(
          IOptions<ApiBehaviorOptions> options,
          IOptions<ProblemDetailsOptions>? problemDetailsOptions = null)
        {
            _options = options?.Value ?? throw new ArgumentNullException(nameof(options));
            _configure = problemDetailsOptions?.Value?.CustomizeProblemDetails;
        }

        public override ProblemDetails CreateProblemDetails(
           HttpContext httpContext,
           int? statusCode = null,
           string? title = null,
           string? type = null,
           string? details = null,
           string? instance = null)
        {
            statusCode ??= 500;
            var problemDetails = new ProblemDetails
            {
                Status = statusCode,
                Title = title,
                Type = type,
                Detail = details,
                Instance = instance,
            };
            ApplyProblemDetailsDefaults(httpContext, problemDetails, statusCode.Value);
            return problemDetails;

        }

        public override ValidationProblemDetails CreateValidationProblemDetails(
            HttpContext httpContext,
            ModelStateDictionary modelStateDictionary,
            int? statusCode = null,
            string? title = null,
            string? type = null,
            string? details = null,
            string? instance = null)
        {
            ArgumentNullException.ThrowIfNull(modelStateDictionary);
            statusCode ??= 400;
            var problemDetails = new ValidationProblemDetails(modelStateDictionary)
            {
                Status = statusCode,
                Type = type,
                Detail = details,
                Instance = instance,
            };
            if (title != null)
            {
                problemDetails.Title = title;
            }
            ApplyProblemDetailsDefaults(httpContext, problemDetails, statusCode.Value);
            return problemDetails;
        }

        private void ApplyProblemDetailsDefaults(HttpContext httpContext, ProblemDetails problemDetails, int statusCode)
        {

            problemDetails.Status ??= statusCode;
            if (_options.ClientErrorMapping.TryGetValue(statusCode, out var clientErrorData))
            {
                problemDetails.Title ??= clientErrorData.Title;
                problemDetails.Type ??= clientErrorData.Link;
            }
            var traceId = Activity.Current?.Id ?? httpContext?.TraceIdentifier;
            if (traceId != null)
                problemDetails.Extensions["traceId"] = traceId;

            _configure?.Invoke(new() { HttpContext = httpContext!, ProblemDetails = problemDetails });
        }

    }

}
