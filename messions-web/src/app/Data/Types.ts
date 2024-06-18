export type user = {
    id: number;
    name: string;
    messions:tasks[]
};
export type tasks ={
    taskId:number;
    userId: number;
    subject:string;
    targetDate:Date;
    isCompleted:boolean
}
export type ApiResponse<T> = {
    success: boolean;
    errorMessage: string;
    data: T;
}