namespace MoustafaMarket.Contracts.Product.Entities.Review;
/* Review creation should not include UserId
 * -----------------------------------------
 * Extract the Id from the JWT token/session.
 * 
 * 1- Security:
 * ------------
 *  Prevent users from creating reviews on behalf of others
 * 2- Consistency
 * --------------
 *  The backend automatically associates the review with the logged-in user.
 * 3- Simplicity
 * -------------
 *  The Client-side doesn't need to handle user Ids
 * 
 * */
public record CreateReviewRequest
(
    string ProductId,
    int Rate,
    string Comment
);
