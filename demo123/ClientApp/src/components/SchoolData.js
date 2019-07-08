import React, { Component } from 'react';
import SchoolAddDailog from './SchoolAddDailog';


export class SchoolData extends Component {
    static displayName = SchoolData.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };

        fetch('api/SchoolData/ShcoolList')
            .then(response => response.json())
            .then(data => {
                console.log(data)
                this.setState({ forecasts: data, loading: false });
            });

    }

    static renderForecastsTable(forecasts) {
        return (
            <table className='table table-striped'>
                <thead>
                    <tr>
                        <th>SchoolCode</th>
                        <th>SchoolName</th>
                        <th>SchoolType</th>
                        <th>Remark</th>
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(forecast =>
                        <tr key={forecast.schoolCode}>
                            <td>{forecast.schoolCode}</td>
                            <td>{forecast.schoolName}</td>
                            <td>{forecast.schoolType}</td>
                            <td>{forecast.remark}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : SchoolData.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1>school data</h1>
                <SchoolAddDailog/>
                {contents}
            </div>
        );
    }

}