import React, { Component } from 'react';


export class SchoolData extends Component {
    static displayName = SchoolData.name;

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };

        fetch('api/SchoolData/ShcoolList')
            .then(response => response.json())
            .then(data => {
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
                        <tr key={forecast.SchoolCode}>
                            <td>{forecast.SchoolCode}</td>
                            <td>{forecast.SchoolName}</td>
                            <td>{forecast.SchoolType}</td>
                            <td>{forecast.Remark}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

}