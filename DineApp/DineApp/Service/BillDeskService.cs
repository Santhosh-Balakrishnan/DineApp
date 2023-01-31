using DineApp.Models;

namespace DineApp.Service
{
    public class BillDeskService:IBillDeskService
    {
        public BillDeskService()
        {
            BillDesk= new BillDesk(30);
        }

        public BillDesk BillDesk { get ; set; }
    }
}
