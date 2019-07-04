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
                          <Card title="测试环境" bordered={false}>
                              <a href="#" target="_blank" >xx（公用版）</a>
                          </Card>
                      </Col>
                      <Col span={8}>
                          <Card title="测试环境" bordered={false}>
                              <a href="#" target="_blank" >xx（共用版）</a>
                          </Card>
                      </Col>

                  </Row>  </div>

              <div style={{ background: '#ECECEC', padding: '30px' }}>
                  <Row gutter={16}>
                      <Col span={8} style={{ paddingBottom: '30px' }}>
                          <Card title="正式环境" bordered={false}>
                              <a href="#" target="_blank" >xx（xx模式）</a>
                          </Card>
                      </Col>
                      <Col span={8} style={{ paddingBottom: '30px' }}>
                          <Card title="正式环境" bordered={false}>
                              <a href="#" target="_blank" >xxx（xx模式）</a>
                          </Card>
                      </Col>
                      <Col span={8} style={{ paddingBottom: '30px' }}>
                          <Card title="正式环境" bordered={false}>
                              <a href="#" target="_blank" >xxx（xx模式）</a>
                          </Card>
                      </Col>
                      <Col span={8}>
                          <Card title="正式环境" bordered={false}>
                              <a href="#" target="_blank" >xxx（xx模式）</a>
                          </Card>
                      </Col>
                      <Col span={8}>
                          <Card title="正式环境" bordered={false}>
                              <a href="#" target="_blank" >xxx（xx模式）</a>
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

