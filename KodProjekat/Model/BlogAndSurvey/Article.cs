/***********************************************************************
 * Module:  Article.cs
 * Purpose: Definition of the Class Model.BlogAndSurvey.Article
 ***********************************************************************/

using System;

namespace Model.BlogAndSurvey
{
   public class Article : Content
   {
      private string title;
      
      public System.Collections.ArrayList comment;
      
      /// <summary>
      /// Property for collection of Comment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Comment
      {
         get
         {
            if (comment == null)
               comment = new System.Collections.ArrayList();
            return comment;
         }
         set
         {
            RemoveAllComment();
            if (value != null)
            {
               foreach (Comment oComment in value)
                  AddComment(oComment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Comment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddComment(Comment newComment)
      {
         if (newComment == null)
            return;
         if (this.comment == null)
            this.comment = new System.Collections.ArrayList();
         if (!this.comment.Contains(newComment))
            this.comment.Add(newComment);
      }
      
      /// <summary>
      /// Remove an existing Comment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveComment(Comment oldComment)
      {
         if (oldComment == null)
            return;
         if (this.comment != null)
            if (this.comment.Contains(oldComment))
               this.comment.Remove(oldComment);
      }
      
      /// <summary>
      /// Remove all instances of Comment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllComment()
      {
         if (comment != null)
            comment.Clear();
      }
   
   }
}