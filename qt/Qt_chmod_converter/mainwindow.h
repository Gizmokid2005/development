#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

namespace Ui {
    class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

protected:
    void changeEvent(QEvent *e);

private:
    Ui::MainWindow *ui;

private slots:
    void on_checkBox_9_clicked();
    void on_checkBox_7_clicked();
    void on_checkBox_6_clicked();
    void on_checkBox_5_clicked();
    void on_checkBox_4_clicked();
    void on_checkBox_3_clicked();
    void on_checkBox_2_clicked();
    void on_checkBox_clicked();
    void on_checkBox_8_clicked();
    void on_lneString_textEdited(QString );
    void on_lneChmod_textEdited(QString );
    void on_btnCvtString_clicked();
    void on_btnClear_clicked();
    void on_btnCvtChmod_clicked();
    void on_btnCvtBoxes_clicked();
};

#endif // MAINWINDOW_H
