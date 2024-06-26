using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

/// <summary>
/// Represents a service for managing comment entities.
/// </summary>
///<remarks> Grupo 1: Carga sin estres </remarks>
public interface ICommentService {

    /// <summary>
    /// Saves a new comment entity asynchronously.
    /// </summary>
    /// <param name="comment">The comment entity to be saved.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the saved comment entity.</returns>
    Task<CommentResponse> SaveAsync(Comment comment);

    /// <summary>
    /// Gets a list of comments associated with a worker asynchronously.
    /// </summary>
    /// <param name="workerId">The identifier of the worker.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of comment entities.</returns>
    Task<IEnumerable<Comment>> ListByWorkerIdAsync(int workerId);
    
    /// <summary>
    /// Deletes a comment entity asynchronously by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the comment entity.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the deleted comment entity.</returns>
    Task<CommentResponse> DeleteAsync(int id);

    /// <summary>
    /// Updates an existing comment entity asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the comment entity to be updated.</param>
    /// <param name="comment">The updated comment entity.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the updated comment entity.</returns>
    Task<CommentResponse> UpdateAsync(int id, Comment comment);
}