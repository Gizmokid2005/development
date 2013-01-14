#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "qmessagebox.h"

#include <QDebug>

QString c1,c2,c3,c4,c5,c6,c7,c8,c9;
int ch1,ch2,ch3,ch4,ch5,ch6,ch7,ch8,ch9;

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->lneString->setValidator(new QRegExpValidator(QRegExp("(?:[-r][-w][-x]){3}"), this));
    ui->lneChmod->setValidator(new QRegExpValidator(QRegExp("[0-7]{3}"), this));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::changeEvent(QEvent *e)
{
    QMainWindow::changeEvent(e);
    switch (e->type()) {
    case QEvent::LanguageChange:
        ui->retranslateUi(this);
        break;
    default:
        break;
    }
}

void MainWindow::on_btnCvtBoxes_clicked()
{
    if (ui->checkBox->isChecked()==true){
        ch1 = 4;
        c1 = "r";
    }
    else{
        c1="-";
        ch1= 0;
    }
    if (ui->checkBox_2->isChecked()==true){
        ch2 = 2;
        c2="w";
    }
    else{
        ch2 = 0;
        c2="-";
    }
    if (ui->checkBox_3->isChecked()==true){
        ch3 = 1;
        c3 = "x";
    }
    else{
        ch3 = 0;
        c3 = "-";
    }
    if (ui->checkBox_4->isChecked()==true){
        ch4 = 4;
        c4 = "r";
    }
    else{
        ch4 = 0;
        c4 = "-";
    }
    if (ui->checkBox_5->isChecked()==true){
        ch5 = 2;
        c5 = "w";
    }
    else{
        ch5 = 0;
        c5 = "-";
    }
    if (ui->checkBox_6->isChecked()==true){
        ch6 = 1;
        c6 = "x";
    }
    else{
        ch6 = 0;
        c6 = "-";
    }
    if (ui->checkBox_7->isChecked()==true){
        ch7 = 4;
        c7 = "r";
    }
    else{
        ch7 = 0;
        c7 = "-";
    }
    if (ui->checkBox_8->isChecked()==true){
        ch8 = 2;
        c8 = "w";
    }
    else{
        ch8 = 0;
        c8 = "-";
    }
    if (ui->checkBox_9->isChecked()==true){
        ch9 = 1;
        c9 = "x";
    }
    else{
        ch9 = 0;
        c9 = "-";
    }
    ui->lneString->setText(c1.append(c2).append(c3).append(c4).append(c5).append(c6).append(c7).append(c8).append(c9));
    ui->lneChmod->setText(QString("%1%2%3").arg(ch1+ch2+ch3).arg(ch4+ch5+ch6).arg(ch7+ch8+ch9));
}

void MainWindow::on_btnCvtChmod_clicked()
{
    if(ui->lneChmod->text()[0].digitValue()==7){
        ui->checkBox->setChecked(true);
        ui->checkBox_2->setChecked(true);
        ui->checkBox_3->setChecked(true);
        c1="r";
        c2="w";
        c3="x";
    }
    else if(ui->lneChmod->text()[0].digitValue()==6){
        ui->checkBox->setChecked(true);
        ui->checkBox_2->setChecked(true);
        ui->checkBox_3->setChecked(false);
        c1="r";
        c2="w";
        c3="-";
    }
    else if(ui->lneChmod->text()[0].digitValue()==5){
        ui->checkBox->setChecked(true);
        ui->checkBox_2->setChecked(false);
        ui->checkBox_3->setChecked(true);
        c1="r";
        c2="-";
        c3="x";
    }
    else if(ui->lneChmod->text()[0].digitValue()==4){
        ui->checkBox->setChecked(true);
        ui->checkBox_2->setChecked(false);
        ui->checkBox_3->setChecked(false);
        c1="r";
        c2="-";
        c3="-";
    }
    else if(ui->lneChmod->text()[0].digitValue()==3){
        ui->checkBox->setChecked(false);
        ui->checkBox_2->setChecked(true);
        ui->checkBox_3->setChecked(true);
        c1="-";
        c2="w";
        c3="x";
    }
    else if(ui->lneChmod->text()[0].digitValue()==2){
        ui->checkBox->setChecked(false);
        ui->checkBox_2->setChecked(true);
        ui->checkBox_3->setChecked(false);
        c1="-";
        c2="w";
        c3="-";
    }
    else if(ui->lneChmod->text()[0].digitValue()==1){
        ui->checkBox->setChecked(false);
        ui->checkBox_2->setChecked(false);
        ui->checkBox_3->setChecked(true);
        c1="-";
        c2="-";
        c3="x";
    }
    else if(ui->lneChmod->text()[0].digitValue()==0){
        ui->checkBox->setChecked(false);
        ui->checkBox_2->setChecked(false);
        ui->checkBox_3->setChecked(false);
        c1="-";
        c2="-";
        c3="-";
    }
    else if(ui->lneChmod->text()[0].isNull()){
        ui->checkBox->setChecked(false);
        ui->checkBox_2->setChecked(false);
        ui->checkBox_3->setChecked(false);
        c1="-";
        c2="-";
        c3="-";
    }
    if(ui->lneChmod->text()[1].digitValue()==7){
        ui->checkBox_4->setChecked(true);
        ui->checkBox_5->setChecked(true);
        ui->checkBox_6->setChecked(true);
        c4="r";
        c5="w";
        c6="x";
    }
    else if(ui->lneChmod->text()[1].digitValue()==6){
        ui->checkBox_4->setChecked(true);
        ui->checkBox_5->setChecked(true);
        ui->checkBox_6->setChecked(false);
        c4="r";
        c5="w";
        c6="-";
    }
    else if(ui->lneChmod->text()[1].digitValue()==5){
        ui->checkBox_4->setChecked(true);
        ui->checkBox_5->setChecked(false);
        ui->checkBox_6->setChecked(true);
        c4="r";
        c5="-";
        c6="x";
    }
    else if(ui->lneChmod->text()[1].digitValue()==4){
        ui->checkBox_4->setChecked(true);
        ui->checkBox_5->setChecked(false);
        ui->checkBox_6->setChecked(false);
        c4="r";
        c5="-";
        c6="-";
    }
    else if(ui->lneChmod->text()[1].digitValue()==3){
        ui->checkBox_4->setChecked(false);
        ui->checkBox_5->setChecked(true);
        ui->checkBox_6->setChecked(true);
        c4="-";
        c5="w";
        c6="x";
    }
    else if(ui->lneChmod->text()[1].digitValue()==2){
        ui->checkBox_4->setChecked(false);
        ui->checkBox_5->setChecked(true);
        ui->checkBox_6->setChecked(false);
        c4="-";
        c5="w";
        c6="-";
    }
    else if(ui->lneChmod->text()[1].digitValue()==1){
        ui->checkBox_4->setChecked(false);
        ui->checkBox_5->setChecked(false);
        ui->checkBox_6->setChecked(true);
        c4="-";
        c5="-";
        c6="x";
    }
    else if(ui->lneChmod->text()[1].digitValue()==0){
        ui->checkBox_4->setChecked(false);
        ui->checkBox_5->setChecked(false);
        ui->checkBox_6->setChecked(false);
        c4="-";
        c5="-";
        c6="-";
    }
    else if(ui->lneChmod->text()[1].isNull()){
        ui->checkBox_4->setChecked(false);
        ui->checkBox_5->setChecked(false);
        ui->checkBox_6->setChecked(false);
        c4="-";
        c5="-";
        c6="-";
    }
    if(ui->lneChmod->text()[2].digitValue()==7){
        ui->checkBox_7->setChecked(true);
        ui->checkBox_8->setChecked(true);
        ui->checkBox_9->setChecked(true);
        c7="r";
        c8="w";
        c9="x";
    }
    else if(ui->lneChmod->text()[2].digitValue()==6){
        ui->checkBox_7->setChecked(true);
        ui->checkBox_8->setChecked(true);
        ui->checkBox_9->setChecked(false);
        c7="r";
        c8="w";
        c9="-";
    }
    else if(ui->lneChmod->text()[2].digitValue()==5){
        ui->checkBox_7->setChecked(true);
        ui->checkBox_8->setChecked(false);
        ui->checkBox_9->setChecked(true);
        c7="r";
        c8="-";
        c9="x";
    }
    else if(ui->lneChmod->text()[2].digitValue()==4){
        ui->checkBox_7->setChecked(true);
        ui->checkBox_8->setChecked(false);
        ui->checkBox_9->setChecked(false);
        c7="r";
        c8="-";
        c9="-";
    }
    else if(ui->lneChmod->text()[2].digitValue()==3){
        ui->checkBox_7->setChecked(false);
        ui->checkBox_8->setChecked(true);
        ui->checkBox_9->setChecked(true);
        c7="-";
        c8="w";
        c9="x";
    }
    else if(ui->lneChmod->text()[2].digitValue()==2){
        ui->checkBox_7->setChecked(false);
        ui->checkBox_8->setChecked(true);
        ui->checkBox_9->setChecked(false);
        c7="-";
        c8="w";
        c9="-";
    }
    else if(ui->lneChmod->text()[2].digitValue()==1){
        ui->checkBox_7->setChecked(false);
        ui->checkBox_8->setChecked(false);
        ui->checkBox_9->setChecked(true);
        c7="-";
        c8="-";
        c9="x";
    }
    else if(ui->lneChmod->text()[2].digitValue()==0){
        ui->checkBox_7->setChecked(false);
        ui->checkBox_8->setChecked(false);
        ui->checkBox_9->setChecked(false);
        c7="-";
        c8="-";
        c9="-";
    }
    else if(ui->lneChmod->text()[2].isNull()){
        ui->checkBox_7->setChecked(false);
        ui->checkBox_8->setChecked(false);
        ui->checkBox_9->setChecked(false);
        c7="-";
        c8="-";
        c9="-";
    }
   ui->lneString->setText(c1.append(c2).append(c3).append(c4).append(c5).append(c6).append(c7).append(c8).append(c9));
    }

void MainWindow::on_btnClear_clicked()
{
    ui->checkBox->setChecked(false);
    ui->checkBox_2->setChecked(false);
    ui->checkBox_3->setChecked(false);
    ui->checkBox_4->setChecked(false);
    ui->checkBox_5->setChecked(false);
    ui->checkBox_6->setChecked(false);
    ui->checkBox_7->setChecked(false);
    ui->checkBox_8->setChecked(false);
    ui->checkBox_9->setChecked(false);
    ui->lneChmod->setText("");
    ui->lneString->setText("");
}

void MainWindow::on_btnCvtString_clicked()
{
    if (ui->lneString->text().toLower()[0] == QChar('r')){
        ui->checkBox->setChecked(true);
        ch1 = 4;
    }
    else{
        ui->checkBox->setChecked(false);
        ch1 = 0;
    }
    if (ui->lneString->text().toLower()[1] == QChar('w')){
        ui->checkBox_2->setChecked(true);
        ch2 = 2;
    }
    else{
        ui->checkBox_2->setChecked(false);
        ch2 = 0;
    }
    if (ui->lneString->text().toLower()[2] == QChar('x')){
        ui->checkBox_3->setChecked(true);
        ch3 = 1;
    }
    else{
        ui->checkBox_3->setChecked(false);
        ch3 = 0;
    }
    if (ui->lneString->text().toLower()[3] == QChar('r')){
        ui->checkBox_4->setChecked(true);
        ch4 = 4;
    }
    else{
        ui->checkBox_4->setChecked(false);
        ch4 = 0;
    }
    if (ui->lneString->text().toLower()[4] == QChar('w')){
        ui->checkBox_5->setChecked(true);
        ch5 = 2;
    }
    else{
        ui->checkBox_5->setChecked(false);
        ch5 = 0;
    }
    if (ui->lneString->text().toLower()[5] == QChar('x')){
        ui->checkBox_6->setChecked(true);
        ch6 = 1;
    }
    else{
        ui->checkBox_6->setChecked(false);
        ch6 = 0;
    }
    if (ui->lneString->text().toLower()[6] == QChar('r')){
        ui->checkBox_7->setChecked(true);
        ch7 = 4;
    }
    else{
        ui->checkBox_7->setChecked(false);
        ch7 = 0;
    }
    if (ui->lneString->text().toLower()[7] == QChar('w')){
        ui->checkBox_8->setChecked(true);
        ch8 = 2;
    }
    else{
        ui->checkBox_8->setChecked(false);
        ch8 = 0;
    }
    if (ui->lneString->text().toLower()[8] == QChar('x')){
        ui->checkBox_9->setChecked(true);
        ch9 = 1;
    }
    else{
        ui->checkBox_9->setChecked(false);
        ch9 = 0;
    }
    ui->lneChmod->setText(QString("%1%2%3").arg(ch1+ch2+ch3).arg(ch4+ch5+ch6).arg(ch7+ch8+ch9));
    }

void MainWindow::on_lneChmod_textEdited(QString )
{
    on_btnCvtChmod_clicked();
}

void MainWindow::on_lneString_textEdited(QString )
{
    on_btnCvtString_clicked();
}

void MainWindow::on_checkBox_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_2_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_3_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_4_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_5_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_6_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_7_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_8_clicked()
{
    on_btnCvtBoxes_clicked();
}

void MainWindow::on_checkBox_9_clicked()
{
    on_btnCvtBoxes_clicked();
}
