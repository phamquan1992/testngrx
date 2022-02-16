import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { catchError, map, of, switchMap } from "rxjs";
import { DataService } from "src/app/service/data.service";
import { FECTH_BAIDANG, FECTH_BAIDANG_FAILURE, FECTH_BAIDANG_SUCCESS } from "../actions/baidang.action";

@Injectable()
export class BaidangEffect {
    constructor(private action$: Actions,
        private dataService: DataService) { }
    loadBaidang$ = createEffect(() =>
        this.action$.pipe(
            ofType(FECTH_BAIDANG),
            switchMap(() =>
                this.dataService.get('api/baidang').pipe(
                    map((baidangs: any) => FECTH_BAIDANG_SUCCESS({ baidangs })),
                    catchError(error => of(FECTH_BAIDANG_FAILURE()))
                )
            )
        )
    )
}