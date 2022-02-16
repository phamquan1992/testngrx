import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { catchError, map, mergeMap, of, switchMap, tap } from "rxjs";
import { DataService } from "src/app/service/data.service";
import { FECTH_BAIDANG, FECTH_BAIDANG_FAILURE, FECTH_BAIDANG_SUCCESS, GET_BAIDANG_OBJ, GET_BAIDANG_OBJ_FAIL, GET_BAIDANG_OBJ_SUCCESS } from "../actions/baidang.action";

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
    );
    getBaidangObj$ = createEffect(() =>
        this.action$.pipe(
            ofType(GET_BAIDANG_OBJ),
            mergeMap(({ url }) =>
                this.dataService.getbykey(url).pipe(
                    map((bai_dang:any) => GET_BAIDANG_OBJ_SUCCESS({ bai_dang })),
                    tap(),
                    catchError(error =>
                        of(GET_BAIDANG_OBJ_FAIL())
                    )
                ),
            )
        )
    );
}