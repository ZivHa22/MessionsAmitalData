import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { ApiResponse, user } from '../Data/Types';

@Injectable({
    providedIn: 'root'
})

export class UsersService {
    
    constructor(private httpService: HttpService) { }

    public async GetUsets(): Promise<ApiResponse<user[]>>{
        const res = await this.httpService.get<any>('Api/GetUsers');
        return res.data
    }
  
}