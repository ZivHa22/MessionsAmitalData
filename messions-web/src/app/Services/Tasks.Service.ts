import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { ApiResponse, tasks, user } from '../Data/Types';

@Injectable({
    providedIn: 'root'
})

export class TasksService {
    
    constructor(private httpService: HttpService) { }

    public async AddTask(task:tasks): Promise<ApiResponse<boolean>>{
        const res = await this.httpService.post<any>('Api/AddTask',task);
        return res.data
    }

    public async GetAllMession(): Promise<ApiResponse<tasks[]>>{
        const res = await this.httpService.get<any>('Api/GetAllMession');
        return res.data
    }
    public async GetOpenMession(): Promise<ApiResponse<user[]>>{
        const res = await this.httpService.get<any>('Api/GetOpenMession');
        return res.data
    }
    
  
}