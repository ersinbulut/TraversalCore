﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitAprroval(int id);//onay bekliyen
        List<Reservation> GetListWithReservationByAccepted(int id);//kabul edilen
        List<Reservation> GetListWithReservationByPrevious(int id);//geçmiş 
    }
}
