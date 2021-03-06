﻿using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
  public  interface IServiceRooms : IServiceBase<Rooms>
  {
      IEnumerable<Rooms> GetDateRooms(DateTime startDateTime, DateTime endDateTime, int thisId = 0);
      IEnumerable<Rooms> GetTypeRooms(int typeId);
      IEnumerable<Rooms> GetTypeAndDateRooms(DateTime startDateTime, DateTime endDateTime, int typeId, int thisId = 0);
  }
}
