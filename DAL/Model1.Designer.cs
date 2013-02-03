﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("QuizModel", "FK_Answer_Question", "Question", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(DAL.Question), "Answer", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(DAL.Answer), true)]

#endregion

namespace DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class QuizEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new QuizEntities object using the connection string found in the 'QuizEntities' section of the application configuration file.
        /// </summary>
        public QuizEntities() : base("name=QuizEntities", "QuizEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new QuizEntities object.
        /// </summary>
        public QuizEntities(string connectionString) : base(connectionString, "QuizEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new QuizEntities object.
        /// </summary>
        public QuizEntities(EntityConnection connection) : base(connection, "QuizEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Answer> Answers
        {
            get
            {
                if ((_Answers == null))
                {
                    _Answers = base.CreateObjectSet<Answer>("Answers");
                }
                return _Answers;
            }
        }
        private ObjectSet<Answer> _Answers;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Question> Questions
        {
            get
            {
                if ((_Questions == null))
                {
                    _Questions = base.CreateObjectSet<Question>("Questions");
                }
                return _Questions;
            }
        }
        private ObjectSet<Question> _Questions;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<QuizResponse> QuizResponses
        {
            get
            {
                if ((_QuizResponses == null))
                {
                    _QuizResponses = base.CreateObjectSet<QuizResponse>("QuizResponses");
                }
                return _QuizResponses;
            }
        }
        private ObjectSet<QuizResponse> _QuizResponses;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Answers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAnswers(Answer answer)
        {
            base.AddObject("Answers", answer);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Questions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToQuestions(Question question)
        {
            base.AddObject("Questions", question);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the QuizResponses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToQuizResponses(QuizResponse quizResponse)
        {
            base.AddObject("QuizResponses", quizResponse);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="QuizModel", Name="Answer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Answer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Answer object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="questionId">Initial value of the QuestionId property.</param>
        /// <param name="answerId">Initial value of the AnswerId property.</param>
        /// <param name="answer1">Initial value of the Answer1 property.</param>
        public static Answer CreateAnswer(global::System.Int32 id, global::System.Int32 questionId, global::System.Int32 answerId, global::System.String answer1)
        {
            Answer answer = new Answer();
            answer.Id = id;
            answer.QuestionId = questionId;
            answer.AnswerId = answerId;
            answer.Answer1 = answer1;
            return answer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                OnQuestionIdChanging(value);
                ReportPropertyChanging("QuestionId");
                _QuestionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QuestionId");
                OnQuestionIdChanged();
            }
        }
        private global::System.Int32 _QuestionId;
        partial void OnQuestionIdChanging(global::System.Int32 value);
        partial void OnQuestionIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AnswerId
        {
            get
            {
                return _AnswerId;
            }
            set
            {
                OnAnswerIdChanging(value);
                ReportPropertyChanging("AnswerId");
                _AnswerId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AnswerId");
                OnAnswerIdChanged();
            }
        }
        private global::System.Int32 _AnswerId;
        partial void OnAnswerIdChanging(global::System.Int32 value);
        partial void OnAnswerIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Answer1
        {
            get
            {
                return _Answer1;
            }
            set
            {
                OnAnswer1Changing(value);
                ReportPropertyChanging("Answer1");
                _Answer1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Answer1");
                OnAnswer1Changed();
            }
        }
        private global::System.String _Answer1;
        partial void OnAnswer1Changing(global::System.String value);
        partial void OnAnswer1Changed();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("QuizModel", "FK_Answer_Question", "Question")]
        public Question Question
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Question>("QuizModel.FK_Answer_Question", "Question").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Question>("QuizModel.FK_Answer_Question", "Question").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Question> QuestionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Question>("QuizModel.FK_Answer_Question", "Question");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Question>("QuizModel.FK_Answer_Question", "Question", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="QuizModel", Name="Question")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Question : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Question object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="questionText">Initial value of the QuestionText property.</param>
        public static Question CreateQuestion(global::System.Int32 id, global::System.String questionText)
        {
            Question question = new Question();
            question.Id = id;
            question.QuestionText = questionText;
            return question;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String QuestionText
        {
            get
            {
                return _QuestionText;
            }
            set
            {
                OnQuestionTextChanging(value);
                ReportPropertyChanging("QuestionText");
                _QuestionText = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("QuestionText");
                OnQuestionTextChanged();
            }
        }
        private global::System.String _QuestionText;
        partial void OnQuestionTextChanging(global::System.String value);
        partial void OnQuestionTextChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("QuizModel", "FK_Answer_Question", "Answer")]
        public EntityCollection<Answer> Answers
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Answer>("QuizModel.FK_Answer_Question", "Answer");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Answer>("QuizModel.FK_Answer_Question", "Answer", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="QuizModel", Name="QuizResponse")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class QuizResponse : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new QuizResponse object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="questionId">Initial value of the QuestionId property.</param>
        /// <param name="answerId">Initial value of the AnswerId property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        public static QuizResponse CreateQuizResponse(global::System.Int32 id, global::System.Int32 questionId, global::System.Int32 answerId, global::System.DateTime date)
        {
            QuizResponse quizResponse = new QuizResponse();
            quizResponse.Id = id;
            quizResponse.QuestionId = questionId;
            quizResponse.AnswerId = answerId;
            quizResponse.Date = date;
            return quizResponse;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                OnQuestionIdChanging(value);
                ReportPropertyChanging("QuestionId");
                _QuestionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QuestionId");
                OnQuestionIdChanged();
            }
        }
        private global::System.Int32 _QuestionId;
        partial void OnQuestionIdChanging(global::System.Int32 value);
        partial void OnQuestionIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AnswerId
        {
            get
            {
                return _AnswerId;
            }
            set
            {
                OnAnswerIdChanging(value);
                ReportPropertyChanging("AnswerId");
                _AnswerId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AnswerId");
                OnAnswerIdChanged();
            }
        }
        private global::System.Int32 _AnswerId;
        partial void OnAnswerIdChanging(global::System.Int32 value);
        partial void OnAnswerIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();

        #endregion
    
    }

    #endregion
    
}
