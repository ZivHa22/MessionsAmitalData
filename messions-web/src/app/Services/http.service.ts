import axios, { AxiosInstance, AxiosRequestConfig } from 'axios';
import { ApiResponse } from '../Data/Types';

export class HttpService {
    private axiosInstance: AxiosInstance;
    private baseURL :string= "https://localhost:7292/"
    constructor() {
        this.axiosInstance = axios.create({
            baseURL: this.baseURL,
            headers: {
                'Content-Type': 'application/json'
            }
        });

   
    }

  

    public async get<T>(url: string, config?: AxiosRequestConfig): Promise<ApiResponse<T>> {
        const response = await this.axiosInstance.get<T,any>(url, config);
        return response;
    }

    public async post<T>(url: string, data?: any, config?: AxiosRequestConfig):Promise<ApiResponse<T>> {
        const response = await this.axiosInstance.post<T,any>(url, data, config);
        return response?.data;
    }

    public async put<T>(url: string, data?: any, config?: AxiosRequestConfig): Promise<T> {
        const response = await this.axiosInstance.put<T>(url, data, config);
        return response.data;
    }

    public async delete<T>(url: string, config?: AxiosRequestConfig): Promise<T> {
        const response = await this.axiosInstance.delete<T>(url, config);
        return response.data;
    }
}
