﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ZhonTai.Common.Domain.Dto;
using ZhonTai.Plate.Admin.Service.Permission;
using ZhonTai.Plate.Admin.Service.Permission.Dto;

namespace ZhonTai.Plate.Admin.HttpApi
{
    /// <summary>
    /// 权限管理
    /// </summary>
    public class PermissionController : AreaController
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        /// <summary>
        /// 查询权限列表
        /// </summary>
        /// <param name="key"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetList(string key, DateTime? start, DateTime? end)
        {
            return await _permissionService.GetListAsync(key, start, end);
        }

        /// <summary>
        /// 查询单条分组
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetGroup(long id)
        {
            return await _permissionService.GetGroupAsync(id);
        }

        /// <summary>
        /// 查询单条菜单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetMenu(long id)
        {
            return await _permissionService.GetMenuAsync(id);
        }

        /// <summary>
        /// 查询单条接口
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetApi(long id)
        {
            return await _permissionService.GetApiAsync(id);
        }

        /// <summary>
        /// 查询单条权限点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetDot(long id)
        {
            return await _permissionService.GetDotAsync(id);
        }

        /// <summary>
        /// 查询角色权限-权限列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetPermissionList()
        {
            return await _permissionService.GetPermissionList();
        }

        /// <summary>
        /// 查询角色权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetRolePermissionList(long roleId = 0)
        {
            return await _permissionService.GetRolePermissionList(roleId);
        }

        /// <summary>
        /// 查询租户权限
        /// </summary>
        /// <param name="tenantId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IResultOutput> GetTenantPermissionList(long tenantId = 0)
        {
            return await _permissionService.GetTenantPermissionList(tenantId);
        }

        /// <summary>
        /// 新增分组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResultOutput> AddGroup(PermissionAddGroupInput input)
        {
            return await _permissionService.AddGroupAsync(input);
        }

        /// <summary>
        /// 新增菜单
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResultOutput> AddMenu(PermissionAddMenuInput input)
        {
            return await _permissionService.AddMenuAsync(input);
        }

        /// <summary>
        /// 新增接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResultOutput> AddApi(PermissionAddApiInput input)
        {
            return await _permissionService.AddApiAsync(input);
        }

        /// <summary>
        /// 新增权限点
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResultOutput> AddDot(PermissionAddDotInput input)
        {
            return await _permissionService.AddDotAsync(input);
        }

        /// <summary>
        /// 修改分组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IResultOutput> UpdateGroup(PermissionUpdateGroupInput input)
        {
            return await _permissionService.UpdateGroupAsync(input);
        }

        /// <summary>
        /// 修改菜单
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IResultOutput> UpdateMenu(PermissionUpdateMenuInput input)
        {
            return await _permissionService.UpdateMenuAsync(input);
        }

        /// <summary>
        /// 修改接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IResultOutput> UpdateApi(PermissionUpdateApiInput input)
        {
            return await _permissionService.UpdateApiAsync(input);
        }

        /// <summary>
        /// 修改权限点
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IResultOutput> UpdateDot(PermissionUpdateDotInput input)
        {
            return await _permissionService.UpdateDotAsync(input);
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IResultOutput> SoftDelete(long id)
        {
            return await _permissionService.SoftDeleteAsync(id);
        }

        /// <summary>
        /// 彻底删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IResultOutput> Delete(long id)
        {
            return await _permissionService.DeleteAsync(id);
        }

        /// <summary>
        /// 保存角色权限
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResultOutput> Assign(PermissionAssignInput input)
        {
            return await _permissionService.AssignAsync(input);
        }

        /// <summary>
        /// 保存租户权限
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IResultOutput> SaveTenantPermissions(PermissionSaveTenantPermissionsInput input)
        {
            return await _permissionService.SaveTenantPermissionsAsync(input);
        }
    }
}