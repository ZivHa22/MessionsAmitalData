import { Component } from '@angular/core';
import { user } from 'src/app/Data/Types';
import { TasksService } from 'src/app/Services/Tasks.Service';

@Component({
  selector: 'app-open-messions',
  templateUrl: './open-messions.component.html',
  styleUrls: ['./open-messions.component.scss']
})
export class OpenMessionsComponent {
 
  
  usersList: user[];
  constructor(private tasksService: TasksService) { }

  async ngOnInit() {
    this.usersList = (await this.tasksService.GetOpenMession()).data
    debugger
  }
}

