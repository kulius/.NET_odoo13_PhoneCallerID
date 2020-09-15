# -*- coding: utf-8 -*-
# Part of Odoo. See LICENSE file for full copyright and licensing details.
{
    'name': '來電歷史記錄',
    'version': '13.0',
    'summary': '結合C#來電記錄',
    'author': 'kulius',
    'license': "AGPL-3",
    'description': """
        結合C#來電記錄
    """,
    'images': ['images/phone.png'],
    'category': "Sales",
    'depends': ['contacts'],
    'data': [
        'views/res_partner_calls_views.xml',
        'security/ir.model.access.csv',
        # 'views/pos_event_templates.xml'
             ],

    'installable': True,
    'auto_install': False,
    'application': True,
}
