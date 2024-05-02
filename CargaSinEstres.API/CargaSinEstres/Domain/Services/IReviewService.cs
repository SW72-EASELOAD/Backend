using CargaSinEstres.API.CargaSinEstres.Domain.Models;
using CargaSinEstres.API.CargaSinEstres.Domain.Services.Communication;
using CargaSinEstres.API.CargaSinEstres.Resources;

namespace CargaSinEstres.API.CargaSinEstres.Domain.Services;

/// <summary>
/// Represents a service for managing review entities.
/// </summary>
///<remarks> Grupo 1: Carga sin estres </remarks>
public interface IReviewService{
    /// <summary>
    /// Gets a list of all review entities asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of review entities.</returns>
    Task<IEnumerable<Review>> ListAsync();
    
    /// <summary>
    /// Gets a list of review entities associated with a specific company asynchronously.
    /// </summary>
    /// <param name="companyId">The unique identifier of the company.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of review entities associated with the specified company.</returns>
    Task<IEnumerable<Review>> FindByCompanyIdAsync(int companyId);
    
    /// <summary>
    /// Saves a new review entity asynchronously.
    /// </summary>
    /// <param name="review">The review entity to be saved.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the saved review entity.</returns>
    Task<ReviewResponse> SaveAsync(Review review);
    
    /// <summary>
    /// Deletes a review entity asynchronously by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the review entity.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the deleted review entity.</returns>
    Task<ReviewResponse> DeleteAsync(int id);
    
    /// <summary>
    /// Updates an existing review entity asynchronously.
    /// </summary>
    /// <param name="id">The unique identifier of the review entity to be updated.</param>
    /// <param name="review">The updated review entity.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the updated review entity.</returns>
    Task<ReviewResponse> UpdateAsync(int id, Review review);
}