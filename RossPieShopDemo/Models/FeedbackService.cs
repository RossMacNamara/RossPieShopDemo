using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RossPieShopDemo.Models
{
    public class FeedbackService : IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;
        public FeedbackService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
            _appDbContext.SaveChanges();
        }
    }
}
