﻿using System.Linq;
using Core;
using PharmacySolution.Contracts.Repository;
using PharmacySolution.Contracts.Validator;

namespace PharmacySolution.BusinessLogic.Validators
{
    public class StorageValidator: IValidator<Storage>
    {
        private readonly IRepository<Storage> _storageRepository = null;

        public StorageValidator(IRepository<Storage> storageRepository)
        {
            _storageRepository = storageRepository;
        }
        public bool IsValid(Storage entity)
        {
            return
                _storageRepository.FindAll()
                    .FirstOrDefault(m => m.MedicamentId == entity.MedicamentId && m.PharmacyId == entity.PharmacyId) ==
                null;
        }
    }
}
