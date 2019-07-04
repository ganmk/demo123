import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import Card from 'antd/lib/card';
import Col from 'antd/lib/col';
import Row from 'antd/lib/row';

export class Home extends Component {
  static displayName = Home.name;

  render () {
      return (
          <div>
              <div style={{ background: '#ECECEC', padding: '30px' }}>
                  <Row gutter={16}>
                      <Col span={8}>
                          <Card title="���Ի���" bordered={false}>
                              <a href="#" target="_blank" >xx�����ð棩</a>
                          </Card>
                      </Col>
                      <Col span={8}>
                          <Card title="���Ի���" bordered={false}>
                              <a href="#" target="_blank" >xx�����ð棩</a>
                          </Card>
                      </Col>

                  </Row>  </div>

              <div style={{ background: '#ECECEC', padding: '30px' }}>
                  <Row gutter={16}>
                      <Col span={8} style={{ paddingBottom: '30px' }}>
                          <Card title="��ʽ����" bordered={false}>
                              <a href="#" target="_blank" >xx��xxģʽ��</a>
                          </Card>
                      </Col>
                      <Col span={8} style={{ paddingBottom: '30px' }}>
                          <Card title="��ʽ����" bordered={false}>
                              <a href="#" target="_blank" >xxx��xxģʽ��</a>
                          </Card>
                      </Col>
                      <Col span={8} style={{ paddingBottom: '30px' }}>
                          <Card title="��ʽ����" bordered={false}>
                              <a href="#" target="_blank" >xxx��xxģʽ��</a>
                          </Card>
                      </Col>
                      <Col span={8}>
                          <Card title="��ʽ����" bordered={false}>
                              <a href="#" target="_blank" >xxx��xxģʽ��</a>
                          </Card>
                      </Col>
                      <Col span={8}>
                          <Card title="��ʽ����" bordered={false}>
                              <a href="#" target="_blank" >xxx��xxģʽ��</a>
                          </Card>
                      </Col>

                  </Row>
              </div>
          </div>
      );
  }
}

ReactDOM.render(
    <Home />,
    document.getElementById('root')
);

