/***********************************************************************
 * Module:  Survey.cs
 * Purpose: Definition of the Class Model.Pacijent.Survey
 ***********************************************************************/

using System;

namespace Model.BlogAndSurvey
{
   public class Survey
   {
      private string content;
      private DateTime publishingDate;
      
      public System.Collections.ArrayList qustions;
      
      /// <summary>
      /// Property for collection of Qustions
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Qustions
      {
         get
         {
            if (qustions == null)
               qustions = new System.Collections.ArrayList();
            return qustions;
         }
         set
         {
            RemoveAllQustions();
            if (value != null)
            {
               foreach (Qustions oQustions in value)
                  AddQustions(oQustions);
            }
         }
      }
      
      /// <summary>
      /// Add a new Qustions in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddQustions(Qustions newQustions)
      {
         if (newQustions == null)
            return;
         if (this.qustions == null)
            this.qustions = new System.Collections.ArrayList();
         if (!this.qustions.Contains(newQustions))
            this.qustions.Add(newQustions);
      }
      
      /// <summary>
      /// Remove an existing Qustions from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveQustions(Qustions oldQustions)
      {
         if (oldQustions == null)
            return;
         if (this.qustions != null)
            if (this.qustions.Contains(oldQustions))
               this.qustions.Remove(oldQustions);
      }
      
      /// <summary>
      /// Remove all instances of Qustions from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllQustions()
      {
         if (qustions != null)
            qustions.Clear();
      }
   
   }
}