using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAxisActor2D
	/// </summary>
	/// <remarks>
	///    Create an axis with tick marks and labels
	///
	/// vtkAxisActor2D creates an axis with tick marks, labels, and/or a title,
	/// depending on the particular instance variable settings. vtkAxisActor2D is
	/// a 2D actor; that is, it is drawn on the overlay plane and is not
	/// occluded by 3D geometry. To use this class, you typically specify two
	/// points defining the start and end points of the line (x-y definition using
	/// vtkCoordinate class), the number of labels, and the data range
	/// (min,max). You can also control what parts of the axis are visible
	/// including the line, the tick marks, the labels, and the title.  You can
	/// also specify the label format (a printf style format).
	///
	/// This class decides what font size to use and how to locate the labels. It
	/// also decides how to create reasonable tick marks and labels. The number
	/// of labels and the range of values may not match the number specified, but
	/// should be close.
	///
	/// Labels are drawn on the "right" side of the axis. The "right" side is
	/// the side of the axis on the right as you move from Position to Position2.
	/// The way the labels and title line up with the axis and tick marks depends on
	/// whether the line is considered horizontal or vertical.
	///
	/// The vtkActor2D instance variables Position and Position2 are instances of
	/// vtkCoordinate. Note that the Position2 is an absolute position in that
	/// class (it was by default relative to Position in vtkActor2D).
	///
	/// What this means is that you can specify the axis in a variety of coordinate
	/// systems. Also, the axis does not have to be either horizontal or vertical.
	/// The tick marks are created so that they are perpendicular to the axis.
	///
	/// Set the text property/attributes of the title and the labels through the
	/// vtkTextProperty objects associated to this actor.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCubeAxesActor2D can be used to create axes in world coordinate space.
	///
	///
	/// vtkActor2D vtkTextMapper vtkPolyDataMapper2D vtkScalarBarActor
	/// vtkCoordinate vtkTextProperty
	/// </seealso>
	// Token: 0x020003BB RID: 955
	public class vtkAxisActor2D : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AF96 RID: 44950 RVA: 0x000F8AC3 File Offset: 0x000F6CC3
		static vtkAxisActor2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxisActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisActor2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AF97 RID: 44951 RVA: 0x000F8AEB File Offset: 0x000F6CEB
		public vtkAxisActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AF98 RID: 44952
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x0600AF99 RID: 44953 RVA: 0x000F8AFC File Offset: 0x000F6CFC
		public new static vtkAxisActor2D New()
		{
			vtkAxisActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object.
		/// </summary>
		// Token: 0x0600AF9A RID: 44954 RVA: 0x000F8B50 File Offset: 0x000F6D50
		public vtkAxisActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAxisActor2D.vtkAxisActor2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AF9B RID: 44955 RVA: 0x000F8B94 File Offset: 0x000F6D94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AF9C RID: 44956
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_AdjustLabelsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600AF9D RID: 44957 RVA: 0x000F8B9F File Offset: 0x000F6D9F
		public virtual void AdjustLabelsOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_AdjustLabelsOff_01(base.GetCppThis());
		}

		// Token: 0x0600AF9E RID: 44958
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_AdjustLabelsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600AF9F RID: 44959 RVA: 0x000F8BAE File Offset: 0x000F6DAE
		public virtual void AdjustLabelsOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_AdjustLabelsOn_02(base.GetCppThis());
		}

		// Token: 0x0600AFA0 RID: 44960
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_AxisVisibilityOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// </summary>
		// Token: 0x0600AFA1 RID: 44961 RVA: 0x000F8BBD File Offset: 0x000F6DBD
		public virtual void AxisVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_AxisVisibilityOff_03(base.GetCppThis());
		}

		// Token: 0x0600AFA2 RID: 44962
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_AxisVisibilityOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// </summary>
		// Token: 0x0600AFA3 RID: 44963 RVA: 0x000F8BCC File Offset: 0x000F6DCC
		public virtual void AxisVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_AxisVisibilityOn_04(base.GetCppThis());
		}

		// Token: 0x0600AFA4 RID: 44964
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_ComputeRange_05(IntPtr inRange, IntPtr outRange, int inNumTicks, ref int outNumTicks, ref double interval);

		/// <summary>
		/// This method computes the range of the axis given an input range.
		/// It also computes the number of tick marks given a suggested number.
		/// (The number of tick marks includes end ticks as well.)
		/// The number of tick marks computed (in conjunction with the output
		/// range) will yield "nice" tick values. For example, if the input range
		/// is (0.25,96.7) and the number of ticks requested is 10, the output range
		/// will be (0,100) with the number of computed ticks to 11 to yield tick
		/// values of (0,10,20,...,100).
		/// </summary>
		// Token: 0x0600AFA5 RID: 44965 RVA: 0x000F8BDB File Offset: 0x000F6DDB
		public static void ComputeRange(IntPtr inRange, IntPtr outRange, int inNumTicks, ref int outNumTicks, ref double interval)
		{
			vtkAxisActor2D.vtkAxisActor2D_ComputeRange_05(inRange, outRange, inNumTicks, ref outNumTicks, ref interval);
		}

		// Token: 0x0600AFA6 RID: 44966
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetAdjustLabels_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600AFA7 RID: 44967 RVA: 0x000F8BEC File Offset: 0x000F6DEC
		public virtual int GetAdjustLabels()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAdjustLabels_06(base.GetCppThis());
		}

		// Token: 0x0600AFA8 RID: 44968
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetAdjustedNumberOfLabels_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600AFA9 RID: 44969 RVA: 0x000F8C0C File Offset: 0x000F6E0C
		public virtual int GetAdjustedNumberOfLabels()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAdjustedNumberOfLabels_07(base.GetCppThis());
		}

		// Token: 0x0600AFAA RID: 44970
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetAdjustedRange_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600AFAB RID: 44971 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		public virtual IntPtr GetAdjustedRange()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAdjustedRange_08(base.GetCppThis());
		}

		// Token: 0x0600AFAC RID: 44972
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_GetAdjustedRange_09(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600AFAD RID: 44973 RVA: 0x000F8C4B File Offset: 0x000F6E4B
		public virtual void GetAdjustedRange(ref double _arg1, ref double _arg2)
		{
			vtkAxisActor2D.vtkAxisActor2D_GetAdjustedRange_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600AFAE RID: 44974
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_GetAdjustedRange_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600AFAF RID: 44975 RVA: 0x000F8C5C File Offset: 0x000F6E5C
		public virtual void GetAdjustedRange(IntPtr _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_GetAdjustedRange_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AFB0 RID: 44976
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetAxisVisibility_11(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// </summary>
		// Token: 0x0600AFB1 RID: 44977 RVA: 0x000F8C6C File Offset: 0x000F6E6C
		public virtual int GetAxisVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAxisVisibility_11(base.GetCppThis());
		}

		// Token: 0x0600AFB2 RID: 44978
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetFontFactor_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes. This ivar used in conjunction with
		/// the LabelFactor can be used to control font sizes.
		/// </summary>
		// Token: 0x0600AFB3 RID: 44979 RVA: 0x000F8C8C File Offset: 0x000F6E8C
		public virtual double GetFontFactor()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetFontFactor_12(base.GetCppThis());
		}

		// Token: 0x0600AFB4 RID: 44980
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetFontFactorMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes. This ivar used in conjunction with
		/// the LabelFactor can be used to control font sizes.
		/// </summary>
		// Token: 0x0600AFB5 RID: 44981 RVA: 0x000F8CAC File Offset: 0x000F6EAC
		public virtual double GetFontFactorMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetFontFactorMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600AFB6 RID: 44982
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetFontFactorMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes. This ivar used in conjunction with
		/// the LabelFactor can be used to control font sizes.
		/// </summary>
		// Token: 0x0600AFB7 RID: 44983 RVA: 0x000F8CCC File Offset: 0x000F6ECC
		public virtual double GetFontFactorMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetFontFactorMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600AFB8 RID: 44984
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetLabelFactor_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the axis labels
		/// to the axis title.
		/// </summary>
		// Token: 0x0600AFB9 RID: 44985 RVA: 0x000F8CEC File Offset: 0x000F6EEC
		public virtual double GetLabelFactor()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelFactor_15(base.GetCppThis());
		}

		// Token: 0x0600AFBA RID: 44986
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetLabelFactorMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the axis labels
		/// to the axis title.
		/// </summary>
		// Token: 0x0600AFBB RID: 44987 RVA: 0x000F8D0C File Offset: 0x000F6F0C
		public virtual double GetLabelFactorMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelFactorMaxValue_16(base.GetCppThis());
		}

		// Token: 0x0600AFBC RID: 44988
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetLabelFactorMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the axis labels
		/// to the axis title.
		/// </summary>
		// Token: 0x0600AFBD RID: 44989 RVA: 0x000F8D2C File Offset: 0x000F6F2C
		public virtual double GetLabelFactorMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelFactorMinValue_17(base.GetCppThis());
		}

		// Token: 0x0600AFBE RID: 44990
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetLabelFormat_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on the scalar
		/// bar.
		/// </summary>
		// Token: 0x0600AFBF RID: 44991 RVA: 0x000F8D4C File Offset: 0x000F6F4C
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxisActor2D.vtkAxisActor2D_GetLabelFormat_18(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600AFC0 RID: 44992
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetLabelTextProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text property.
		/// </summary>
		// Token: 0x0600AFC1 RID: 44993 RVA: 0x000F8D88 File Offset: 0x000F6F88
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetLabelTextProperty_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600AFC2 RID: 44994
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetLabelVisibility_20(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// </summary>
		// Token: 0x0600AFC3 RID: 44995 RVA: 0x000F8DF8 File Offset: 0x000F6FF8
		public virtual int GetLabelVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelVisibility_20(base.GetCppThis());
		}

		// Token: 0x0600AFC4 RID: 44996
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetMinorTickLength_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the length of the minor tick marks (expressed in pixels or
		/// display coordinates).
		/// </summary>
		// Token: 0x0600AFC5 RID: 44997 RVA: 0x000F8E18 File Offset: 0x000F7018
		public virtual int GetMinorTickLength()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetMinorTickLength_21(base.GetCppThis());
		}

		// Token: 0x0600AFC6 RID: 44998
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetMinorTickLengthMaxValue_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the length of the minor tick marks (expressed in pixels or
		/// display coordinates).
		/// </summary>
		// Token: 0x0600AFC7 RID: 44999 RVA: 0x000F8E38 File Offset: 0x000F7038
		public virtual int GetMinorTickLengthMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetMinorTickLengthMaxValue_22(base.GetCppThis());
		}

		// Token: 0x0600AFC8 RID: 45000
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetMinorTickLengthMinValue_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the length of the minor tick marks (expressed in pixels or
		/// display coordinates).
		/// </summary>
		// Token: 0x0600AFC9 RID: 45001 RVA: 0x000F8E58 File Offset: 0x000F7058
		public virtual int GetMinorTickLengthMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetMinorTickLengthMinValue_23(base.GetCppThis());
		}

		// Token: 0x0600AFCA RID: 45002
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisActor2D_GetNumberOfGenerationsFromBase_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AFCB RID: 45003 RVA: 0x000F8E78 File Offset: 0x000F7078
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfGenerationsFromBase_24(base.GetCppThis(), type);
		}

		// Token: 0x0600AFCC RID: 45004
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAxisActor2D_GetNumberOfGenerationsFromBaseType_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AFCD RID: 45005 RVA: 0x000F8E98 File Offset: 0x000F7098
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfGenerationsFromBaseType_25(type);
		}

		// Token: 0x0600AFCE RID: 45006
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetNumberOfLabels_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show. This also controls the
		/// number of major ticks shown. Note that this ivar only holds meaning if
		/// the RulerMode is off.
		/// </summary>
		// Token: 0x0600AFCF RID: 45007 RVA: 0x000F8EB4 File Offset: 0x000F70B4
		public virtual int GetNumberOfLabels()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfLabels_26(base.GetCppThis());
		}

		// Token: 0x0600AFD0 RID: 45008
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetNumberOfLabelsMaxValue_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show. This also controls the
		/// number of major ticks shown. Note that this ivar only holds meaning if
		/// the RulerMode is off.
		/// </summary>
		// Token: 0x0600AFD1 RID: 45009 RVA: 0x000F8ED4 File Offset: 0x000F70D4
		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfLabelsMaxValue_27(base.GetCppThis());
		}

		// Token: 0x0600AFD2 RID: 45010
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetNumberOfLabelsMinValue_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show. This also controls the
		/// number of major ticks shown. Note that this ivar only holds meaning if
		/// the RulerMode is off.
		/// </summary>
		// Token: 0x0600AFD3 RID: 45011 RVA: 0x000F8EF4 File Offset: 0x000F70F4
		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfLabelsMinValue_28(base.GetCppThis());
		}

		// Token: 0x0600AFD4 RID: 45012
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetNumberOfMinorTicks_29(HandleRef pThis);

		/// <summary>
		/// Number of minor ticks to be displayed between each tick. Default
		/// is 0.
		/// </summary>
		// Token: 0x0600AFD5 RID: 45013 RVA: 0x000F8F14 File Offset: 0x000F7114
		public virtual int GetNumberOfMinorTicks()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfMinorTicks_29(base.GetCppThis());
		}

		// Token: 0x0600AFD6 RID: 45014
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetNumberOfMinorTicksMaxValue_30(HandleRef pThis);

		/// <summary>
		/// Number of minor ticks to be displayed between each tick. Default
		/// is 0.
		/// </summary>
		// Token: 0x0600AFD7 RID: 45015 RVA: 0x000F8F34 File Offset: 0x000F7134
		public virtual int GetNumberOfMinorTicksMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfMinorTicksMaxValue_30(base.GetCppThis());
		}

		// Token: 0x0600AFD8 RID: 45016
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetNumberOfMinorTicksMinValue_31(HandleRef pThis);

		/// <summary>
		/// Number of minor ticks to be displayed between each tick. Default
		/// is 0.
		/// </summary>
		// Token: 0x0600AFD9 RID: 45017 RVA: 0x000F8F54 File Offset: 0x000F7154
		public virtual int GetNumberOfMinorTicksMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfMinorTicksMinValue_31(base.GetCppThis());
		}

		// Token: 0x0600AFDA RID: 45018
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetPoint1_32(HandleRef pThis);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// Note: backward compatibility only, use vtkActor2D's Position instead.
		/// </summary>
		// Token: 0x0600AFDB RID: 45019 RVA: 0x000F8F74 File Offset: 0x000F7174
		public virtual IntPtr GetPoint1()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetPoint1_32(base.GetCppThis());
		}

		// Token: 0x0600AFDC RID: 45020
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetPoint1Coordinate_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// Note: backward compatibility only, use vtkActor2D's Position instead.
		/// </summary>
		// Token: 0x0600AFDD RID: 45021 RVA: 0x000F8F94 File Offset: 0x000F7194
		public virtual vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetPoint1Coordinate_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600AFDE RID: 45022
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetPoint2_34(HandleRef pThis);

		/// <summary>
		/// Specify the position of the second point defining the axis. Note that
		/// the order from Point1 to Point2 controls which side the tick marks
		/// are drawn on (ticks are drawn on the right, if visible).
		/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
		/// </summary>
		// Token: 0x0600AFDF RID: 45023 RVA: 0x000F9004 File Offset: 0x000F7204
		public virtual IntPtr GetPoint2()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetPoint2_34(base.GetCppThis());
		}

		// Token: 0x0600AFE0 RID: 45024
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetPoint2Coordinate_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the position of the second point defining the axis. Note that
		/// the order from Point1 to Point2 controls which side the tick marks
		/// are drawn on (ticks are drawn on the right, if visible).
		/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
		/// </summary>
		// Token: 0x0600AFE1 RID: 45025 RVA: 0x000F9024 File Offset: 0x000F7224
		public virtual vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetPoint2Coordinate_35(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		// Token: 0x0600AFE2 RID: 45026
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetRange_36(HandleRef pThis);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// </summary>
		// Token: 0x0600AFE3 RID: 45027 RVA: 0x000F9094 File Offset: 0x000F7294
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetRange_36(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AFE4 RID: 45028
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_GetRange_37(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// </summary>
		// Token: 0x0600AFE5 RID: 45029 RVA: 0x000F90DC File Offset: 0x000F72DC
		public virtual void GetRange(IntPtr data)
		{
			vtkAxisActor2D.vtkAxisActor2D_GetRange_37(base.GetCppThis(), data);
		}

		// Token: 0x0600AFE6 RID: 45030
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetRulerDistance_38(HandleRef pThis);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x0600AFE7 RID: 45031 RVA: 0x000F90EC File Offset: 0x000F72EC
		public virtual double GetRulerDistance()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerDistance_38(base.GetCppThis());
		}

		// Token: 0x0600AFE8 RID: 45032
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetRulerDistanceMaxValue_39(HandleRef pThis);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x0600AFE9 RID: 45033 RVA: 0x000F910C File Offset: 0x000F730C
		public virtual double GetRulerDistanceMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerDistanceMaxValue_39(base.GetCppThis());
		}

		// Token: 0x0600AFEA RID: 45034
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetRulerDistanceMinValue_40(HandleRef pThis);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x0600AFEB RID: 45035 RVA: 0x000F912C File Offset: 0x000F732C
		public virtual double GetRulerDistanceMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerDistanceMinValue_40(base.GetCppThis());
		}

		// Token: 0x0600AFEC RID: 45036
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetRulerMode_41(HandleRef pThis);

		/// <summary>
		/// Specify whether this axis should act like a measuring tape (or ruler) with
		/// specified major tick spacing. If enabled, the distance between major ticks
		/// is controlled by the RulerDistance ivar.
		/// </summary>
		// Token: 0x0600AFED RID: 45037 RVA: 0x000F914C File Offset: 0x000F734C
		public virtual int GetRulerMode()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerMode_41(base.GetCppThis());
		}

		// Token: 0x0600AFEE RID: 45038
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetSizeFontRelativeToAxis_42(HandleRef pThis);

		/// <summary>
		/// Specify whether to size the fonts relative to the viewport or relative to
		/// length of the axis. By default, fonts are resized relative to the viewport.
		/// </summary>
		// Token: 0x0600AFEF RID: 45039 RVA: 0x000F916C File Offset: 0x000F736C
		public virtual int GetSizeFontRelativeToAxis()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetSizeFontRelativeToAxis_42(base.GetCppThis());
		}

		// Token: 0x0600AFF0 RID: 45040
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTickLength_43(HandleRef pThis);

		/// <summary>
		/// Set/Get the length of the tick marks (expressed in pixels or display
		/// coordinates).
		/// </summary>
		// Token: 0x0600AFF1 RID: 45041 RVA: 0x000F918C File Offset: 0x000F738C
		public virtual int GetTickLength()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickLength_43(base.GetCppThis());
		}

		// Token: 0x0600AFF2 RID: 45042
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTickLengthMaxValue_44(HandleRef pThis);

		/// <summary>
		/// Set/Get the length of the tick marks (expressed in pixels or display
		/// coordinates).
		/// </summary>
		// Token: 0x0600AFF3 RID: 45043 RVA: 0x000F91AC File Offset: 0x000F73AC
		public virtual int GetTickLengthMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickLengthMaxValue_44(base.GetCppThis());
		}

		// Token: 0x0600AFF4 RID: 45044
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTickLengthMinValue_45(HandleRef pThis);

		/// <summary>
		/// Set/Get the length of the tick marks (expressed in pixels or display
		/// coordinates).
		/// </summary>
		// Token: 0x0600AFF5 RID: 45045 RVA: 0x000F91CC File Offset: 0x000F73CC
		public virtual int GetTickLengthMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickLengthMinValue_45(base.GetCppThis());
		}

		// Token: 0x0600AFF6 RID: 45046
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTickOffset_46(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the labels (expressed in pixels or display
		/// coordinates). The offset is the distance of labels from tick marks
		/// or other objects.
		/// </summary>
		// Token: 0x0600AFF7 RID: 45047 RVA: 0x000F91EC File Offset: 0x000F73EC
		public virtual int GetTickOffset()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickOffset_46(base.GetCppThis());
		}

		// Token: 0x0600AFF8 RID: 45048
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTickOffsetMaxValue_47(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the labels (expressed in pixels or display
		/// coordinates). The offset is the distance of labels from tick marks
		/// or other objects.
		/// </summary>
		// Token: 0x0600AFF9 RID: 45049 RVA: 0x000F920C File Offset: 0x000F740C
		public virtual int GetTickOffsetMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickOffsetMaxValue_47(base.GetCppThis());
		}

		// Token: 0x0600AFFA RID: 45050
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTickOffsetMinValue_48(HandleRef pThis);

		/// <summary>
		/// Set/Get the offset of the labels (expressed in pixels or display
		/// coordinates). The offset is the distance of labels from tick marks
		/// or other objects.
		/// </summary>
		// Token: 0x0600AFFB RID: 45051 RVA: 0x000F922C File Offset: 0x000F742C
		public virtual int GetTickOffsetMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickOffsetMinValue_48(base.GetCppThis());
		}

		// Token: 0x0600AFFC RID: 45052
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTickVisibility_49(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis tick marks.
		/// </summary>
		// Token: 0x0600AFFD RID: 45053 RVA: 0x000F924C File Offset: 0x000F744C
		public virtual int GetTickVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickVisibility_49(base.GetCppThis());
		}

		// Token: 0x0600AFFE RID: 45054
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetTitle_50(HandleRef pThis);

		/// <summary>
		/// Set/Get the title of the scalar bar actor,
		/// </summary>
		// Token: 0x0600AFFF RID: 45055 RVA: 0x000F926C File Offset: 0x000F746C
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkAxisActor2D.vtkAxisActor2D_GetTitle_50(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B000 RID: 45056
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAxisActor2D_GetTitlePosition_51(HandleRef pThis);

		/// <summary>
		/// Set/Get position of the axis title. 0 is at the start of the
		/// axis whereas 1 is at the end.
		/// </summary>
		// Token: 0x0600B001 RID: 45057 RVA: 0x000F92A8 File Offset: 0x000F74A8
		public virtual double GetTitlePosition()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTitlePosition_51(base.GetCppThis());
		}

		// Token: 0x0600B002 RID: 45058
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_GetTitleTextProperty_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600B003 RID: 45059 RVA: 0x000F92C8 File Offset: 0x000F74C8
		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetTitleTextProperty_52(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B004 RID: 45060
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetTitleVisibility_53(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// </summary>
		// Token: 0x0600B005 RID: 45061 RVA: 0x000F9338 File Offset: 0x000F7538
		public virtual int GetTitleVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTitleVisibility_53(base.GetCppThis());
		}

		// Token: 0x0600B006 RID: 45062
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_GetUseFontSizeFromProperty_54(HandleRef pThis);

		/// <summary>
		/// By default the AxisActor controls the font size of the axis label.  If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the axis size.
		/// </summary>
		// Token: 0x0600B007 RID: 45063 RVA: 0x000F9358 File Offset: 0x000F7558
		public virtual int GetUseFontSizeFromProperty()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetUseFontSizeFromProperty_54(base.GetCppThis());
		}

		// Token: 0x0600B008 RID: 45064
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_HasTranslucentPolygonalGeometry_55(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B009 RID: 45065 RVA: 0x000F9378 File Offset: 0x000F7578
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAxisActor2D.vtkAxisActor2D_HasTranslucentPolygonalGeometry_55(base.GetCppThis());
		}

		// Token: 0x0600B00A RID: 45066
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_IsA_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B00B RID: 45067 RVA: 0x000F9398 File Offset: 0x000F7598
		public override int IsA(string type)
		{
			return vtkAxisActor2D.vtkAxisActor2D_IsA_56(base.GetCppThis(), type);
		}

		// Token: 0x0600B00C RID: 45068
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_IsTypeOf_57([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B00D RID: 45069 RVA: 0x000F93B8 File Offset: 0x000F75B8
		public new static int IsTypeOf(string type)
		{
			return vtkAxisActor2D.vtkAxisActor2D_IsTypeOf_57(type);
		}

		// Token: 0x0600B00E RID: 45070
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_LabelVisibilityOff_58(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// </summary>
		// Token: 0x0600B00F RID: 45071 RVA: 0x000F93D2 File Offset: 0x000F75D2
		public virtual void LabelVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_LabelVisibilityOff_58(base.GetCppThis());
		}

		// Token: 0x0600B010 RID: 45072
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_LabelVisibilityOn_59(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// </summary>
		// Token: 0x0600B011 RID: 45073 RVA: 0x000F93E1 File Offset: 0x000F75E1
		public virtual void LabelVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_LabelVisibilityOn_59(base.GetCppThis());
		}

		// Token: 0x0600B012 RID: 45074
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_NewInstance_61(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B013 RID: 45075 RVA: 0x000F93F0 File Offset: 0x000F75F0
		public new vtkAxisActor2D NewInstance()
		{
			vtkAxisActor2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_NewInstance_61(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B014 RID: 45076
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_ReleaseGraphicsResources_62(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B015 RID: 45077 RVA: 0x000F944C File Offset: 0x000F764C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAxisActor2D.vtkAxisActor2D_ReleaseGraphicsResources_62(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B016 RID: 45078
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_RenderOpaqueGeometry_63(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600B017 RID: 45079 RVA: 0x000F947C File Offset: 0x000F767C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxisActor2D.vtkAxisActor2D_RenderOpaqueGeometry_63(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B018 RID: 45080
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_RenderOverlay_64(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600B019 RID: 45081 RVA: 0x000F94B0 File Offset: 0x000F76B0
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAxisActor2D.vtkAxisActor2D_RenderOverlay_64(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x0600B01A RID: 45082
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAxisActor2D_RenderTranslucentPolygonalGeometry_65(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the axis.
		/// </summary>
		// Token: 0x0600B01B RID: 45083 RVA: 0x000F94E4 File Offset: 0x000F76E4
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkAxisActor2D.vtkAxisActor2D_RenderTranslucentPolygonalGeometry_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B01C RID: 45084
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_RulerModeOff_66(HandleRef pThis);

		/// <summary>
		/// Specify whether this axis should act like a measuring tape (or ruler) with
		/// specified major tick spacing. If enabled, the distance between major ticks
		/// is controlled by the RulerDistance ivar.
		/// </summary>
		// Token: 0x0600B01D RID: 45085 RVA: 0x000F9518 File Offset: 0x000F7718
		public virtual void RulerModeOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_RulerModeOff_66(base.GetCppThis());
		}

		// Token: 0x0600B01E RID: 45086
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_RulerModeOn_67(HandleRef pThis);

		/// <summary>
		/// Specify whether this axis should act like a measuring tape (or ruler) with
		/// specified major tick spacing. If enabled, the distance between major ticks
		/// is controlled by the RulerDistance ivar.
		/// </summary>
		// Token: 0x0600B01F RID: 45087 RVA: 0x000F9527 File Offset: 0x000F7727
		public virtual void RulerModeOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_RulerModeOn_67(base.GetCppThis());
		}

		// Token: 0x0600B020 RID: 45088
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAxisActor2D_SafeDownCast_68(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B021 RID: 45089 RVA: 0x000F9538 File Offset: 0x000F7738
		public new static vtkAxisActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_SafeDownCast_68((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		// Token: 0x0600B022 RID: 45090
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetAdjustLabels_69(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag that controls whether the labels and ticks are
		/// adjusted for "nice" numerical values to make it easier to read
		/// the labels. The adjustment is based in the Range instance variable.
		/// Call GetAdjustedRange and GetAdjustedNumberOfLabels to get the adjusted
		/// range and number of labels. Note that if RulerMode is on, then the
		/// number of labels is a function of the range and ruler distance.
		/// </summary>
		// Token: 0x0600B023 RID: 45091 RVA: 0x000F95B7 File Offset: 0x000F77B7
		public virtual void SetAdjustLabels(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetAdjustLabels_69(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B024 RID: 45092
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetAxisVisibility_70(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get visibility of the axis line.
		/// </summary>
		// Token: 0x0600B025 RID: 45093 RVA: 0x000F95C7 File Offset: 0x000F77C7
		public virtual void SetAxisVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetAxisVisibility_70(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B026 RID: 45094
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetFontFactor_71(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the overall size of the fonts used
		/// to label and title the axes. This ivar used in conjunction with
		/// the LabelFactor can be used to control font sizes.
		/// </summary>
		// Token: 0x0600B027 RID: 45095 RVA: 0x000F95D7 File Offset: 0x000F77D7
		public virtual void SetFontFactor(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetFontFactor_71(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B028 RID: 45096
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetLabelFactor_72(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the factor that controls the relative size of the axis labels
		/// to the axis title.
		/// </summary>
		// Token: 0x0600B029 RID: 45097 RVA: 0x000F95E7 File Offset: 0x000F77E7
		public virtual void SetLabelFactor(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelFactor_72(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B02A RID: 45098
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetLabelFormat_73(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on the scalar
		/// bar.
		/// </summary>
		// Token: 0x0600B02B RID: 45099 RVA: 0x000F95F7 File Offset: 0x000F77F7
		public virtual void SetLabelFormat(string _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelFormat_73(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B02C RID: 45100
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetLabelTextProperty_74(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the labels text property.
		/// </summary>
		// Token: 0x0600B02D RID: 45101 RVA: 0x000F9608 File Offset: 0x000F7808
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelTextProperty_74(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B02E RID: 45102
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetLabelVisibility_75(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get visibility of the axis labels.
		/// </summary>
		// Token: 0x0600B02F RID: 45103 RVA: 0x000F9637 File Offset: 0x000F7837
		public virtual void SetLabelVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelVisibility_75(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B030 RID: 45104
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetMinorTickLength_76(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the length of the minor tick marks (expressed in pixels or
		/// display coordinates).
		/// </summary>
		// Token: 0x0600B031 RID: 45105 RVA: 0x000F9647 File Offset: 0x000F7847
		public virtual void SetMinorTickLength(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetMinorTickLength_76(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B032 RID: 45106
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetNumberOfLabels_77(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of annotation labels to show. This also controls the
		/// number of major ticks shown. Note that this ivar only holds meaning if
		/// the RulerMode is off.
		/// </summary>
		// Token: 0x0600B033 RID: 45107 RVA: 0x000F9657 File Offset: 0x000F7857
		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetNumberOfLabels_77(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B034 RID: 45108
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetNumberOfMinorTicks_78(HandleRef pThis, int _arg);

		/// <summary>
		/// Number of minor ticks to be displayed between each tick. Default
		/// is 0.
		/// </summary>
		// Token: 0x0600B035 RID: 45109 RVA: 0x000F9667 File Offset: 0x000F7867
		public virtual void SetNumberOfMinorTicks(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetNumberOfMinorTicks_78(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B036 RID: 45110
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetPoint1_79(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// Note: backward compatibility only, use vtkActor2D's Position instead.
		/// </summary>
		// Token: 0x0600B037 RID: 45111 RVA: 0x000F9677 File Offset: 0x000F7877
		public virtual void SetPoint1(IntPtr x)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint1_79(base.GetCppThis(), x);
		}

		// Token: 0x0600B038 RID: 45112
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetPoint1_80(HandleRef pThis, double x, double y);

		/// <summary>
		/// Specify the position of the first point defining the axis.
		/// Note: backward compatibility only, use vtkActor2D's Position instead.
		/// </summary>
		// Token: 0x0600B039 RID: 45113 RVA: 0x000F9687 File Offset: 0x000F7887
		public virtual void SetPoint1(double x, double y)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint1_80(base.GetCppThis(), x, y);
		}

		// Token: 0x0600B03A RID: 45114
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetPoint2_81(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Specify the position of the second point defining the axis. Note that
		/// the order from Point1 to Point2 controls which side the tick marks
		/// are drawn on (ticks are drawn on the right, if visible).
		/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
		/// </summary>
		// Token: 0x0600B03B RID: 45115 RVA: 0x000F9698 File Offset: 0x000F7898
		public virtual void SetPoint2(IntPtr x)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint2_81(base.GetCppThis(), x);
		}

		// Token: 0x0600B03C RID: 45116
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetPoint2_82(HandleRef pThis, double x, double y);

		/// <summary>
		/// Specify the position of the second point defining the axis. Note that
		/// the order from Point1 to Point2 controls which side the tick marks
		/// are drawn on (ticks are drawn on the right, if visible).
		/// Note: backward compatibility only, use vtkActor2D's Position2 instead.
		/// </summary>
		// Token: 0x0600B03D RID: 45117 RVA: 0x000F96A8 File Offset: 0x000F78A8
		public virtual void SetPoint2(double x, double y)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint2_82(base.GetCppThis(), x, y);
		}

		// Token: 0x0600B03E RID: 45118
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetRange_83(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// </summary>
		// Token: 0x0600B03F RID: 45119 RVA: 0x000F96B9 File Offset: 0x000F78B9
		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRange_83(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600B040 RID: 45120
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetRange_84(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the (min,max) axis range. This will be used in the generation
		/// of labels, if labels are visible.
		/// </summary>
		// Token: 0x0600B041 RID: 45121 RVA: 0x000F96CA File Offset: 0x000F78CA
		public void SetRange(IntPtr _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRange_84(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B042 RID: 45122
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetRulerDistance_85(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x0600B043 RID: 45123 RVA: 0x000F96DA File Offset: 0x000F78DA
		public virtual void SetRulerDistance(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRulerDistance_85(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B044 RID: 45124
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetRulerMode_86(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether this axis should act like a measuring tape (or ruler) with
		/// specified major tick spacing. If enabled, the distance between major ticks
		/// is controlled by the RulerDistance ivar.
		/// </summary>
		// Token: 0x0600B045 RID: 45125 RVA: 0x000F96EA File Offset: 0x000F78EA
		public virtual void SetRulerMode(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRulerMode_86(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B046 RID: 45126
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetSizeFontRelativeToAxis_87(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to size the fonts relative to the viewport or relative to
		/// length of the axis. By default, fonts are resized relative to the viewport.
		/// </summary>
		// Token: 0x0600B047 RID: 45127 RVA: 0x000F96FA File Offset: 0x000F78FA
		public virtual void SetSizeFontRelativeToAxis(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetSizeFontRelativeToAxis_87(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B048 RID: 45128
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetTickLength_88(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the length of the tick marks (expressed in pixels or display
		/// coordinates).
		/// </summary>
		// Token: 0x0600B049 RID: 45129 RVA: 0x000F970A File Offset: 0x000F790A
		public virtual void SetTickLength(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTickLength_88(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B04A RID: 45130
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetTickOffset_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the offset of the labels (expressed in pixels or display
		/// coordinates). The offset is the distance of labels from tick marks
		/// or other objects.
		/// </summary>
		// Token: 0x0600B04B RID: 45131 RVA: 0x000F971A File Offset: 0x000F791A
		public virtual void SetTickOffset(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTickOffset_89(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B04C RID: 45132
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetTickVisibility_90(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get visibility of the axis tick marks.
		/// </summary>
		// Token: 0x0600B04D RID: 45133 RVA: 0x000F972A File Offset: 0x000F792A
		public virtual void SetTickVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTickVisibility_90(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B04E RID: 45134
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetTitle_91(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the title of the scalar bar actor,
		/// </summary>
		// Token: 0x0600B04F RID: 45135 RVA: 0x000F973A File Offset: 0x000F793A
		public virtual void SetTitle(string _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitle_91(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B050 RID: 45136
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetTitlePosition_92(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get position of the axis title. 0 is at the start of the
		/// axis whereas 1 is at the end.
		/// </summary>
		// Token: 0x0600B051 RID: 45137 RVA: 0x000F974A File Offset: 0x000F794A
		public virtual void SetTitlePosition(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitlePosition_92(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B052 RID: 45138
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetTitleTextProperty_93(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600B053 RID: 45139 RVA: 0x000F975C File Offset: 0x000F795C
		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitleTextProperty_93(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B054 RID: 45140
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetTitleVisibility_94(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// </summary>
		// Token: 0x0600B055 RID: 45141 RVA: 0x000F978B File Offset: 0x000F798B
		public virtual void SetTitleVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitleVisibility_94(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B056 RID: 45142
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SetUseFontSizeFromProperty_95(HandleRef pThis, int _arg);

		/// <summary>
		/// By default the AxisActor controls the font size of the axis label.  If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the axis size.
		/// </summary>
		// Token: 0x0600B057 RID: 45143 RVA: 0x000F979B File Offset: 0x000F799B
		public virtual void SetUseFontSizeFromProperty(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetUseFontSizeFromProperty_95(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B058 RID: 45144
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_ShallowCopy_96(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an axis actor. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x0600B059 RID: 45145 RVA: 0x000F97AC File Offset: 0x000F79AC
		public override void ShallowCopy(vtkProp prop)
		{
			vtkAxisActor2D.vtkAxisActor2D_ShallowCopy_96(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		// Token: 0x0600B05A RID: 45146
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SizeFontRelativeToAxisOff_97(HandleRef pThis);

		/// <summary>
		/// Specify whether to size the fonts relative to the viewport or relative to
		/// length of the axis. By default, fonts are resized relative to the viewport.
		/// </summary>
		// Token: 0x0600B05B RID: 45147 RVA: 0x000F97DB File Offset: 0x000F79DB
		public virtual void SizeFontRelativeToAxisOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_SizeFontRelativeToAxisOff_97(base.GetCppThis());
		}

		// Token: 0x0600B05C RID: 45148
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_SizeFontRelativeToAxisOn_98(HandleRef pThis);

		/// <summary>
		/// Specify whether to size the fonts relative to the viewport or relative to
		/// length of the axis. By default, fonts are resized relative to the viewport.
		/// </summary>
		// Token: 0x0600B05D RID: 45149 RVA: 0x000F97EA File Offset: 0x000F79EA
		public virtual void SizeFontRelativeToAxisOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_SizeFontRelativeToAxisOn_98(base.GetCppThis());
		}

		// Token: 0x0600B05E RID: 45150
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_TickVisibilityOff_99(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis tick marks.
		/// </summary>
		// Token: 0x0600B05F RID: 45151 RVA: 0x000F97F9 File Offset: 0x000F79F9
		public virtual void TickVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_TickVisibilityOff_99(base.GetCppThis());
		}

		// Token: 0x0600B060 RID: 45152
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_TickVisibilityOn_100(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis tick marks.
		/// </summary>
		// Token: 0x0600B061 RID: 45153 RVA: 0x000F9808 File Offset: 0x000F7A08
		public virtual void TickVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_TickVisibilityOn_100(base.GetCppThis());
		}

		// Token: 0x0600B062 RID: 45154
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_TitleVisibilityOff_101(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// </summary>
		// Token: 0x0600B063 RID: 45155 RVA: 0x000F9817 File Offset: 0x000F7A17
		public virtual void TitleVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_TitleVisibilityOff_101(base.GetCppThis());
		}

		// Token: 0x0600B064 RID: 45156
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_TitleVisibilityOn_102(HandleRef pThis);

		/// <summary>
		/// Set/Get visibility of the axis title.
		/// </summary>
		// Token: 0x0600B065 RID: 45157 RVA: 0x000F9826 File Offset: 0x000F7A26
		public virtual void TitleVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_TitleVisibilityOn_102(base.GetCppThis());
		}

		// Token: 0x0600B066 RID: 45158
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_UseFontSizeFromPropertyOff_103(HandleRef pThis);

		/// <summary>
		/// By default the AxisActor controls the font size of the axis label.  If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the axis size.
		/// </summary>
		// Token: 0x0600B067 RID: 45159 RVA: 0x000F9835 File Offset: 0x000F7A35
		public virtual void UseFontSizeFromPropertyOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_UseFontSizeFromPropertyOff_103(base.GetCppThis());
		}

		// Token: 0x0600B068 RID: 45160
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAxisActor2D_UseFontSizeFromPropertyOn_104(HandleRef pThis);

		/// <summary>
		/// By default the AxisActor controls the font size of the axis label.  If this
		/// option is set to true, it will instead use whatever font size is set in the
		/// vtkTextProperty, allowing external control of the axis size.
		/// </summary>
		// Token: 0x0600B069 RID: 45161 RVA: 0x000F9844 File Offset: 0x000F7A44
		public virtual void UseFontSizeFromPropertyOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_UseFontSizeFromPropertyOn_104(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DB9 RID: 3513
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxisActor2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DBA RID: 3514
		public new static readonly string MRClassNameKey = "class vtkAxisActor2D";

		/// <summary>
		/// Specify the RulerDistance which indicates the spacing of the major ticks.
		/// This ivar only has effect when the RulerMode is on.
		/// </summary>
		// Token: 0x020003BC RID: 956
		public enum LabelMax
		{
			/// <summary>enum member</summary>
			// Token: 0x04000DBC RID: 3516
			VTK_MAX_LABELS = 25
		}
	}
}
