/***********************************************************************
 * Module:  Bed.cs
 * Purpose: Definition of the Class Model.Term.Bed
 ***********************************************************************/

using System;

namespace Model.Term
{
   public class Bed
   {
      private bool taken;
      
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
   
   }
}