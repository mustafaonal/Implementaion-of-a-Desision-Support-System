using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using weka.core.converters;

namespace WindowsFormsApp1
{
    public partial class Deuceng_Form : Form
    {
        static weka.classifiers.Classifier cl_BEST = null;

        static weka.classifiers.Classifier cl_1NN = null;
        static weka.classifiers.Classifier cl_3NN = null;
        static weka.classifiers.Classifier cl_5NN = null;
        static weka.classifiers.Classifier cl_7NN = null;
        static weka.classifiers.Classifier cl_9NN = null;
        static weka.classifiers.Classifier cl_NB = null;
        static weka.classifiers.Classifier cl_LOG = null;
        static weka.classifiers.Classifier cl_J48 = null;
        static weka.classifiers.Classifier cl_RT = null;
        static weka.classifiers.Classifier cl_RF = null;
        static weka.classifiers.Classifier cl_MLP = null;
        static weka.classifiers.Classifier cl_SVM = null;

        string file_name = "";
        const int percentSplit = 66;

        public static double ClassTest_1NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_1NN = new weka.classifiers.lazy.IBk(1);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_1NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_1NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_3NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_3NN = new weka.classifiers.lazy.IBk(3);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_3NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_3NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_5NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_5NN = new weka.classifiers.lazy.IBk(5);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_5NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_5NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_7NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_7NN = new weka.classifiers.lazy.IBk(7);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_7NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_7NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_9NN(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_9NN = new weka.classifiers.lazy.IBk(9);

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_9NN.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_9NN.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_NB(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_NB = new weka.classifiers.bayes.NaiveBayes();

                //discretize
                weka.filters.Filter myDiscretize = new weka.filters.unsupervised.attribute.Discretize();
                myDiscretize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDiscretize);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_NB.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_NB.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_LOG(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_LOG = new weka.classifiers.functions.Logistic();

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_LOG.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_LOG.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_J48(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_J48 = new weka.classifiers.trees.J48();

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_J48.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_J48.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_RF(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_RF = new weka.classifiers.trees.RandomForest();

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_RF.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_RF.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_RT(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_RT = new weka.classifiers.trees.RandomTree();

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_RT.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_RT.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        public static double ClassTest_MLP(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_MLP = new weka.classifiers.functions.MultilayerPerceptron();

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_MLP.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_MLP.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
          
        }

        public static double ClassTest_SVM(weka.core.Instances insts)
        {
            try
            {
                insts.setClassIndex(insts.numAttributes() - 1);

                cl_SVM = new weka.classifiers.functions.SMO();

                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myDummyAttr);

                weka.filters.Filter myRandom = new weka.filters.unsupervised.instance.Randomize();
                myRandom.setInputFormat(insts);
                insts = weka.filters.Filter.useFilter(insts, myRandom);

                int trainSize = insts.numInstances() * percentSplit / 100;
                int testSize = insts.numInstances() - trainSize;
                weka.core.Instances train = new weka.core.Instances(insts, 0, trainSize);

                cl_SVM.buildClassifier(train);


                int numCorrect = 0;
                for (int i = trainSize; i < insts.numInstances(); i++)
                {
                    weka.core.Instance currentInst = insts.instance(i);
                    double predictedClass = cl_SVM.classifyInstance(currentInst);
                    if (predictedClass == insts.instance(i).classValue())
                        numCorrect++;
                }
                return (double)numCorrect / (double)testSize * 100.0;
            }
            catch (java.lang.Exception ex)
            {
                ex.printStackTrace();
                return 0;
            }
        }

        
        List<Panel> listPanel = new List<Panel>();
        List<Label> listLabel = new List<Label>();
        List<TextBox> listTextbox = new List<TextBox>(); 
        List<ComboBox> listComboBox = new List<ComboBox>();
        int index;
        weka.core.Instances insts;
        weka.core.Instances insts_temp;
        int num_att;
        public Deuceng_Form()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

            listPanel.Add(pnl_intro);
            listPanel.Add(pnl_dataset_info);
            listPanel.Add(pnl_result_and_prediction);
            listPanel[index].BringToFront();


            
        }

        private void btn_select_dataset_Click(object sender, EventArgs e)
        {
           dataset_info_textbox.Text = "";
           Boolean flag = true;

            if(comboBox_datasets.SelectedIndex > -1)
            {
                file_name = comboBox_datasets.Items[comboBox_datasets.SelectedIndex].ToString() + ".arff";
                lbl_dataset_name.Text = "Dataset: " + comboBox_datasets.Items[comboBox_datasets.SelectedIndex].ToString();
                insts = new weka.core.Instances(new java.io.FileReader(file_name));
                insts_temp = new weka.core.Instances(new java.io.FileReader(file_name));
                
                num_att = insts_temp.numAttributes();

                string dataset_info = "Dataset Info: \r\n";

                for (int i = 0; i < num_att; i++)
                {
                    dataset_info += insts_temp.attribute(i).name() + " ";
                    if(insts_temp.attribute(i).isNumeric())
                    {
                        dataset_info += "REAL\r\n";
                    }
                    else
                    {
                        dataset_info += "{";
                        int sub_types_num = insts_temp.attribute(i).numValues();

                        for (int j = 0; j < sub_types_num; j++)
                        {
                            dataset_info += "'" + insts_temp.attribute(i).value(j) + "',";
                        }

                        dataset_info = dataset_info.Substring(0, dataset_info.Length - 1) + "}\r\n";

                    }
                }


                dataset_info_textbox.ScrollBars = ScrollBars.Both;
                dataset_info_textbox.AppendText(dataset_info);

            }
            else
            {
                MessageBox.Show("Please Select Dataset From ComboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
                

            if (index < listPanel.Count - 1 && flag)
                listPanel[++index].BringToFront();
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }


        private void comboBox_datasets_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void pnl_intro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_dataset_info_Paint(object sender, PaintEventArgs e)
        {
  
        }

        private void btn_back_welcome_page_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataset_info_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cont_with_dataset_Click(object sender, EventArgs e)
        {

            string new_file = "@RELATION new_instance\n";

            for (int i = 0; i < num_att; i++)
            {
                new_file += "@ATTRIBUTE " + insts_temp.attribute(i).name() + " ";
                if (insts_temp.attribute(i).isNumeric())
                {
                    new_file += "REAL\n";
                }
                else
                {
                    new_file += "{";
                    int sub_types_num = insts_temp.attribute(i).numValues();

                    for (int j = 0; j < sub_types_num; j++)
                    {
                        new_file += "'" + insts_temp.attribute(i).value(j) + "',";
                    }

                    new_file = new_file.Substring(0, new_file.Length - 1) + "}\n";
                }
            }

            new_file += "@DATA\n";

            double max_acc = 0.00;
            string ml_algoritm_name;

            max_acc = ClassTest_1NN(insts);
            cl_BEST = cl_1NN;
            ml_algoritm_name = "KNN with k=1";

            insts = insts_temp;
            double temp_acc = ClassTest_3NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_3NN;
                ml_algoritm_name = "KNN with k=3";
            }

            insts = insts_temp;
            temp_acc = ClassTest_5NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_5NN;
                ml_algoritm_name = "KNN with k=5";
            }

            insts = insts_temp;
            temp_acc = ClassTest_7NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_7NN;
                ml_algoritm_name = "KNN with k=7";
            }

            insts = insts_temp;
            temp_acc = ClassTest_9NN(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_9NN;
                ml_algoritm_name = "KNN with k=9";
            }

            insts = insts_temp;
            temp_acc = ClassTest_NB(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_NB;
                ml_algoritm_name = "Naive Bayes";
            }

            insts = insts_temp;
            temp_acc = ClassTest_J48(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_J48;
                ml_algoritm_name = "Decision Tree(J48)";
            }

            insts = insts_temp;
            temp_acc = ClassTest_RT(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_RT;
                ml_algoritm_name = "Decision Tree(RT)";
            }

            insts = insts_temp;
            temp_acc = ClassTest_RF(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_RF;
                ml_algoritm_name = "Decision Tree(Random Tree)";
            }

            insts = insts_temp;
            temp_acc = ClassTest_MLP(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_MLP;
                ml_algoritm_name = "MultilayerPerceptron(ANN)";
            }

            insts = insts_temp;
            temp_acc = ClassTest_SVM(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_SVM;
                ml_algoritm_name = "Support Vector Machine";
            }

            insts = insts_temp;
            temp_acc = ClassTest_LOG(insts);

            if (temp_acc > max_acc)
            {
                max_acc = temp_acc;
                cl_BEST = cl_LOG;
                ml_algoritm_name = "Logistic Regression";
            }

            lbl_result_for_dataset.Text = ml_algoritm_name + " is the most successful algorithm for " + file_name.Substring(0, file_name.Length - 5) + " dataset(%" + max_acc + ")\n\n Please Enter Values for New Prediction";

            
            for (int i = 0; i < num_att-1; i++)
            {
                Label mylab = new Label();
                mylab.Text = insts_temp.attribute(i).name();
                mylab.Name = "lbl" + i.ToString();
                mylab.Location = new Point(37, (80+i*30));
                mylab.AutoSize = true;
                mylab.Font = new Font("Microsoft Sans Serif", 9);
                mylab.ForeColor = Color.Black;
                mylab.Tag = "btn";

                listLabel.Add(mylab);
                prediction_panel.Controls.Add(listLabel[i]);
            }

            
            for (int i = 0; i < num_att - 1; i++)
            {
                if (insts_temp.attribute(i).isNumeric())
                {
                    TextBox txt_new = new TextBox();
                    txt_new.Name = "txt" + i.ToString();
                    txt_new.BackColor = Color.White;
                    txt_new.ForeColor = Color.Black;
                    txt_new.Text = "";
                    txt_new.Location = new Point(190, (80 + i * 30));
                    txt_new.Font = new Font("Microsoft Sans Serif", 9);
                    txt_new.Tag = "btn";

                    listTextbox.Add(txt_new);
                    listComboBox.Add(null);
                    prediction_panel.Controls.Add(listTextbox[i]);
                }
                else
                {
                    ComboBox comboBox1 = new ComboBox();
                    comboBox1.Location = new Point(190, (80 + i * 30));
                    comboBox1.Name = "comboBox" + i.ToString();
                    comboBox1.BackColor = Color.White;
                    comboBox1.ForeColor = Color.Black;
                    comboBox1.Font = new Font("Microsoft Sans Serif", 9);
                    int sub_types_num = insts_temp.attribute(i).numValues();

                    for (int j = 0; j < sub_types_num; j++)
                    {
                        comboBox1.Items.Add(insts_temp.attribute(i).value(j));
                    }
                    listComboBox.Add(comboBox1);
                    listTextbox.Add(null);
                    prediction_panel.Controls.Add(listComboBox[i]);
                }
                
            }

            prediction_panel.AutoScroll = true;
            prediction_panel.BorderStyle = BorderStyle.FixedSingle;

            prediction_panel.BringToFront();



            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_info_page_Click(object sender, EventArgs e)
        {
            lbl_prediction.Text = "";
            for (int i = 0; i < num_att - 1; i++)
            {
                prediction_panel.Controls.Remove(listLabel[i]);
                prediction_panel.Controls.Remove(listTextbox[i]);
                prediction_panel.Controls.Remove(listComboBox[i]);
            }
            listLabel.Clear();
            listTextbox.Clear();
            listComboBox.Clear();
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void btn_predict_Click(object sender, EventArgs e)
        {
            string new_file = "@RELATION new_instance\n";

            for (int i = 0; i < num_att; i++)
            {
                new_file += "@ATTRIBUTE " + insts_temp.attribute(i).name() + " ";
                if (insts_temp.attribute(i).isNumeric())
                {
                    new_file += "REAL\n";
                }
                else
                {
                    new_file += "{";
                    int sub_types_num = insts_temp.attribute(i).numValues();

                    for (int j = 0; j < sub_types_num; j++)
                    {
                        new_file += "'" + insts_temp.attribute(i).value(j) + "',";
                    }

                    new_file = new_file.Substring(0, new_file.Length - 1) + "}\n";
                }
            }

            new_file += "@DATA\n";

            for (int i = 0; i < num_att-1; i++)
            {
                if (insts_temp.attribute(i).isNumeric())
                {
                    new_file += listTextbox[i].Text + ",";
                }
                else
                {
                    new_file += listComboBox[i].Items[listComboBox[i].SelectedIndex].ToString() + ",";
                }
            }


            new_file += "?";

            StreamWriter sw_new_inst = new StreamWriter("new_instance.arff");
            sw_new_inst.Write(new_file);
            sw_new_inst.Close();

            weka.core.Instances new_insts = new weka.core.Instances(new java.io.FileReader("new_instance.arff"));
            new_insts.setClassIndex(new_insts.numAttributes() - 1);


            if (cl_BEST.GetType().FullName.ToString() == "weka.classifiers.lazy.IBk" ||
                cl_BEST.GetType().FullName.ToString() == "weka.classifiers.functions.MultilayerPerceptron" ||
                cl_BEST.GetType().FullName.ToString() == "weka.classifiers.functions.SMO" ||
                cl_BEST.GetType().FullName.ToString() == "weka.classifiers.functions.Logistic")
            {
                weka.filters.Filter myNormalize = new weka.filters.unsupervised.attribute.Normalize();
                myNormalize.setInputFormat(new_insts);
                new_insts = weka.filters.Filter.useFilter(new_insts, myNormalize);

                weka.filters.Filter myDummyAttr = new weka.filters.unsupervised.attribute.NominalToBinary();
                myDummyAttr.setInputFormat(new_insts);
                new_insts = weka.filters.Filter.useFilter(new_insts, myDummyAttr);
            }
            else if (cl_BEST.GetType().FullName.ToString() == "weka.classifiers.bayes.NaiveBayes")
            {
                weka.filters.Filter myDiscretize = new weka.filters.unsupervised.attribute.Discretize();
                myDiscretize.setInputFormat(new_insts);
                new_insts = weka.filters.Filter.useFilter(new_insts, myDiscretize);
            }

            double predictedClass = cl_BEST.classifyInstance(new_insts.instance(0));
            lbl_prediction.Text = "Prediction \n\n" + new_insts.classAttribute().value(Convert.ToInt32(predictedClass));


        }
    }
}
