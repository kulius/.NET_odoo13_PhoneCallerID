# -*- coding: utf-8 -*-
from odoo import fields, models, api, _

class ResPartnerCalls(models.Model):
    _name = "res.partner.calls"
    _description = "客戶來電記錄"

    name = fields.Char(string='來電名稱')
    calls = fields.Char(string='來電號碼')
    partner_id = fields.Many2one('res.partner', '客戶')
    callstime = fields.Datetime(string='來電時間')


