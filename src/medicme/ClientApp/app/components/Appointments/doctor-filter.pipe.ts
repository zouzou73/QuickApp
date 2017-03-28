import { PipeTransform, Pipe } from '@angular/core';
import { IDoctor } from './doctor';

@Pipe({
    name: 'doctorFilter'
})
export class DoctorFilterPipe implements PipeTransform {

    transform(value: IDoctor[], filterBy: string): IDoctor[] {
        filterBy = filterBy ? filterBy.toLocaleLowerCase() : null;
        return filterBy ? value.filter((doctor: IDoctor) =>
            doctor.DoctorName.toLocaleLowerCase().indexOf(filterBy) !== -1) : value;
    }
}