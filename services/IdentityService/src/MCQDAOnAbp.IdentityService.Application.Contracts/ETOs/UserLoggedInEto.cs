using System;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus;

namespace MCQDAOnAbp.IdentityService.ETOs
{
    [EventName("MCQDAOnAbp.Identity.UserLoggedIn")]
    public class UserLoggedInEto : EtoBase
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public bool IsEmailVerified { get; set; }
    }
}
