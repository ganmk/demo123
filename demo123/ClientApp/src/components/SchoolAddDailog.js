import React from 'react';
import ReactDOM from 'react-dom';
import {
    Modal,
    Form,
    Input,
    Tooltip,
    Icon,
    Cascader,
    Select,
    Row,
    Col,
    Checkbox,
    Button,
    AutoComplete,
} from 'antd';
import guid from './Guid';
import Fetch from './FetchUtil';


class SchoolAddDailog extends React.Component {
    state = { visible: false };
    showModal = () => {
        this.setState({
            visible: true,
        });
    };

    handleOk = e => {
        console.log(e);
        this.setState({
            visible: false,
        });
    };

    handleCancel = e => {
        console.log(e);
        this.setState({
            visible: false,
        });
    };

    handleSubmit = e => {
        e.preventDefault();
        this.props.form.validateFieldsAndScroll((err, values) => {
            if (!err) {
                console.log('Received values of form: ', values);
                var _data = {
                    "Id": guid(),
                    "SchoolCode": "testcode",
                    "SchoolName": "testname",
                    "SchoolType": 1,
                    "Remark":"test_remark"
                }

                //Fetch("api/SchoolData/AddShcool", { "method":"POST","body":_data });

                //fetch('api/SchoolData/AddShcool', {
                //    method: 'POST',
                //    body: JSON.stringify(_data),
                //    headers: {
                //        'Content-Type': 'application/application/x-www-form-urlencoded'
                //    }
                //})
                //    .then(response => response.json())
                //    .then(data => {
                //        this.setState({
                //            visible: false,
                //        });
                //    });

                fetch("api/SchoolData/AddShcool", {
                    body: JSON.stringify(_data), // must match 'Content-Type' header
                    cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
                    //credentials: 'same-origin', // include, same-origin, *omit
                    headers: {
                        'user-agent': 'Mozilla/4.0 MDN Example',
                        'content-type': 'application/json'
                    },
                    method: 'POST', // *GET, POST, PUT, DELETE, etc.
                    mode: 'cors', // no-cors, cors, *same-origin
                    //redirect: 'follow', // manual, *follow, error
                    referrer: 'no-referrer', // *client, no-referrer
                })
                    .then(response => response.json())
                    .then(data => {
                        //this.setState({
                        //    visible: false,
                        //});
                    });
               
            }

        });

    };

    render() {
        const { getFieldDecorator } = this.props.form;
        const { autoCompleteResult } = this.state;

        const formItemLayout = {
            labelCol: {
                xs: { span: 24 },
                sm: { span: 8 },
            },
            wrapperCol: {
                xs: { span: 24 },
                sm: { span: 16 },
            },
        };

        return (
            <div>
                <Button type="primary" onClick={this.showModal}>
                    Open Modal
                </Button>
                <Modal
                    title="add shcool"
                    visible={this.state.visible}
                    //confirmLoading={this.handleSubmit}
                    okText='保存'
                    cancelText='返回'
                    onOk={this.handleSubmit}
                    onCancel={this.handleCancel}
                >
                    <Form {...formItemLayout}>
                        <Form.Item
                            label={
                                <span>
                                    学校编码&nbsp;
                        </span>
                            }
                        >
                            {getFieldDecorator('SchoolCode', {
                                rules: [{ required: true, message: 'Please input SchoolCode!', whitespace: true }],
                            })(<Input />)}
                        </Form.Item>

                    </Form>
                </Modal>
            </div>
        );

    };

}

export default Form.create()(SchoolAddDailog);