﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Experience;
using Business.Dtos.Requests.PersonalInfo;
using Business.Dtos.Responses.Experience;
using Business.Dtos.Responses.Instructor;
using Business.Dtos.Responses.PersonalInfo;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ExperienceManager : IExperienceService
    {
        IMapper _mapper;
        IExperienceDal _experienceDal;

        public ExperienceManager(IMapper mapper, IExperienceDal experienceDal)
        {
            _mapper = mapper;
            _experienceDal = experienceDal;
        }

        public async Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest)
        {
            Experience experience = _mapper.Map<Experience>(createExperienceRequest);
            var createdExperience = await _experienceDal.AddAsync(experience); // ?? is necessary  --> record
            CreatedExperienceResponse result = _mapper.Map<CreatedExperienceResponse>(experience);
            return result;
        }

        public async Task<DeletedExperienceResponse> DeleteAsync(DeleteExperienceRequest deleteExperienceRequest)
        {
            Experience experience = await _experienceDal.GetAsync(e => e.Id == deleteExperienceRequest.Id);
            var deletedExperience = await _experienceDal.DeleteAsync(experience);
            DeletedExperienceResponse deletedExperienceResponse = _mapper.Map<DeletedExperienceResponse>(deletedExperience);
            return deletedExperienceResponse;
        }

        public async Task<GetExperienceResponse> GetByIdAsync(GetExperienceRequest getExperienceRequest)
        {
            var result = await _experienceDal.GetAsync(i => i.Id == getExperienceRequest.Id);
            return _mapper.Map<GetExperienceResponse>(result);
        }

        public async Task<IPaginate<GetListExperienceResponse>> GetListAsync(PageRequest pageRequest)
        {
            var result = await _experienceDal.GetListAsync(index: pageRequest.PageIndex, size: pageRequest.PageSize);
            return _mapper.Map<Paginate<GetListExperienceResponse>>(result);
        }

        public async Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest)
        {
            Experience experience = _mapper.Map<Experience>(updateExperienceRequest);
            var updatedExperience= await _experienceDal.UpdateAsync(experience);
            UpdatedExperienceResponse updatedExperienceResponse=_mapper.Map<UpdatedExperienceResponse>(updatedExperience);
            return updatedExperienceResponse;

        }
    }
}
