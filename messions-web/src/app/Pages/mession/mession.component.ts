import { Component } from '@angular/core';
import { UsersService } from 'src/app/Services/Users.Service';
import { tasks, user } from 'src/app/Data/Types';
import { TasksService } from 'src/app/Services/Tasks.Service';

@Component({
  selector: 'app-mession',
  templateUrl: './mession.component.html',
  styleUrls: ['./mession.component.scss']
})
export class MessionComponent {

  usersList: user[] = []

  taskList:tasks[]= []
  constructor(private usersService: UsersService, private tasksService: TasksService) { }

  async ngOnInit() {
    this.usersList = (await this.usersService.GetUsets()).data
    this.taskList = (await this.tasksService.GetAllMession()).data
  }

  async AddMession(data: tasks) {
    console.log(data)
    data.isCompleted = false;
    const res = await this.tasksService.AddTask(data)
    if (res){
      location.reload();
    }
  }
}
