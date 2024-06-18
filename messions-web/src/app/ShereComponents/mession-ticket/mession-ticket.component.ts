import { Component, EventEmitter, Input, Output } from '@angular/core';
import { user } from 'src/app/Data/Types';
import dateFormat, { masks } from "dateformat";

@Component({
  selector: 'app-mession-ticket',
  templateUrl: './mession-ticket.component.html',
  styleUrls: ['./mession-ticket.component.scss'],

})
export class MessionTicketComponent {
  @Input() usersList: user[];
  @Input() insertMode: boolean;
  @Input() userSelected: number;
  @Input() subjectTask: string;
  @Input() dateTask: Date;
  @Input() isCompleted: boolean;
  @Output() action = new EventEmitter<any>();

  subject: string;
  userId: number;
  date: Date;
  dateStr:string;

  constructor() {

  }
  ngOnInit() {
    this.subject = this.subjectTask;
    this.userId = this.userSelected;
    this.date = this.dateTask;
    this.dateStr = dateFormat(this.dateTask, "dd/MM/yyyy");
  }

  AddMession = () => {
    const data = {subject:this.subject,userId:this.userId,TargetDate:this.date};
    this.action.emit(data);
  }
}
