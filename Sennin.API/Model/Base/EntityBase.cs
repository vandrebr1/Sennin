using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Sennin.API.Model.Base
{
    public interface IEntityBase<TKey>
    {
        TKey Id { get; set; }
    }

    public interface IDeleteEntity
    {
        bool IsDeleted { get; set; }
    }

    public interface IDeleteEntity<TKey> : IDeleteEntity, IEntityBase<TKey>
    {
    }

    public interface IAuditEntity
    {
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }
    public interface IAuditEntity<TKey> : IAuditEntity, IDeleteEntity<TKey>
    {
    }

    public interface IEmpresaEntity
    {
        int EmpresaId { get; }
    }
    public interface IEmpresaEntity<TKey> : IEmpresaEntity, IAuditEntity<TKey>
    {
    }

    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [SwaggerSchema(ReadOnly = true)]
        public virtual TKey Id { get; set; }
    }

    public abstract class DeleteEntity<TKey> : EntityBase<TKey>, IDeleteEntity<TKey>
    {
        [SwaggerSchema(ReadOnly = true)]
        public bool IsDeleted { get; set; }
    }

    public abstract class AuditEntity<TKey> : DeleteEntity<TKey>, IAuditEntity<TKey>
    {
        [SwaggerSchema(ReadOnly = true)]
        public DateTime CreatedDate { get; set; }


        [SwaggerSchema(ReadOnly = true)]
        public string CreatedBy { get; set; }


        [SwaggerSchema(ReadOnly = true)]
        public DateTime UpdatedDate { get; set; }


        [SwaggerSchema(ReadOnly = true)]
        public string UpdatedBy { get; set; }

        private void SetCreate()
        {
            CreatedDate = DateTime.Now;
            CreatedBy = "SISTEMA";
        }

        private void SetUpdate()
        {
            UpdatedDate = DateTime.Now;
            UpdatedBy = "SISTEMA";
        }

        public void PreenchePropriedadesNovoRegistro()
        {
            SetCreate();
            SetUpdate();
        }

        public void PreenchePropriedadesAtualizaRegistro()
        {
            SetUpdate();
        }

    }

    public abstract class EmpresaEntity<TKey> : AuditEntity<TKey>, IEmpresaEntity<TKey>
    {
        [SwaggerSchema(ReadOnly = true)]
        public int EmpresaId { get => EmpresaLogada(); }

        private int EmpresaLogada()
        {
            return 1;
        }
    }
}
