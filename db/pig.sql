/*
Navicat MySQL Data Transfer

Source Server         : jqt_mysql
Source Server Version : 50519
Source Host           : 123.150.143.151:3306
Source Database       : pig

Target Server Type    : MYSQL
Target Server Version : 50519
File Encoding         : 65001

Date: 2018-12-28 09:45:46
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for t_labels
-- ----------------------------
DROP TABLE IF EXISTS `t_labels`;
CREATE TABLE `t_labels` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `btn` varchar(255) DEFAULT NULL,
  `life_cycle` int(11) DEFAULT '1' COMMENT '生命周期',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for t_weights
-- ----------------------------
DROP TABLE IF EXISTS `t_weights`;
CREATE TABLE `t_weights` (
  `id` varchar(36) NOT NULL,
  `sn` int(11) DEFAULT NULL COMMENT '每日流水号',
  `create_time` varchar(255) DEFAULT NULL COMMENT '录入时间',
  `weight` varchar(255) DEFAULT NULL COMMENT '重量',
  `level` varchar(255) DEFAULT NULL COMMENT '级别',
  `remarks` varchar(255) DEFAULT NULL COMMENT '备注',
  `type` varchar(255) DEFAULT NULL COMMENT '工艺',
  `is_upload` int(11) DEFAULT '0' COMMENT '是否已上传（0：否，1：是）',
  `life_cycle` int(11) DEFAULT '1' COMMENT '生命周期',
  `is_handwrite` int(11) DEFAULT '0' COMMENT '是否补录（0：否，1：是）',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
