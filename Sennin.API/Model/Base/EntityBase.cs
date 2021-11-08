using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sennin.API.Model.Base
{
    public interface IEntityBase<TKey>
    {
        TKey Id { get; set; }
        bool IsDeleted { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }

    public interface IEmpresaEntity
    {
        int EmpresaId { get; set; }
    }
    public interface IEmpresaEntity<TKey> : IEmpresaEntity, IEntityBase<TKey>
    {

    }
    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [SwaggerSchema(ReadOnly = true)]
        public virtual TKey Id { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        public bool IsDeleted { get; set; }

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

    public abstract class EmpresaEntity<TKey> : EntityBase<TKey>, IEmpresaEntity<TKey>
    {
        [SwaggerSchema(ReadOnly = true)]
        public int EmpresaId { get; set; }
    }
}
