/***********************************************************************
 * Module:  Renovation.cs
 * Purpose: Definition of the Class Model.Term.Renovation
 ***********************************************************************/

using System;

namespace Model.Term
{
   public class Renovation
   {
      private bool split;
      private bool merge;
      
      public DateAndTimeOfTerm dateAndTimeOfTerm;
      
      /// <summary>
      /// Property for DateAndTimeOfTerm
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public DateAndTimeOfTerm DateAndTimeOfTerm
      {
         get
         {
            return dateAndTimeOfTerm;
         }
         set
         {
            this.dateAndTimeOfTerm = value;
         }
      }
      public System.Collections.ArrayList room;
      
      /// <summary>
      /// Property for collection of Room
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Room
      {
         get
         {
            if (room == null)
               room = new System.Collections.ArrayList();
            return room;
         }
         set
         {
            RemoveAllRoom();
            if (value != null)
            {
               foreach (Room oRoom in value)
                  AddRoom(oRoom);
            }
         }
      }
      
      /// <summary>
      /// Add a new Room in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRoom(Room newRoom)
      {
         if (newRoom == null)
            return;
         if (this.room == null)
            this.room = new System.Collections.ArrayList();
         if (!this.room.Contains(newRoom))
            this.room.Add(newRoom);
      }
      
      /// <summary>
      /// Remove an existing Room from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRoom(Room oldRoom)
      {
         if (oldRoom == null)
            return;
         if (this.room != null)
            if (this.room.Contains(oldRoom))
               this.room.Remove(oldRoom);
      }
      
      /// <summary>
      /// Remove all instances of Room from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRoom()
      {
         if (room != null)
            room.Clear();
      }
   
   }
}