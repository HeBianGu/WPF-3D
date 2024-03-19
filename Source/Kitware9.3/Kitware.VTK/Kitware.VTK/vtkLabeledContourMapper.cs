using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabeledContourMapper
	/// </summary>
	/// <remarks>
	///    Draw labeled isolines.
	///
	/// Draw isolines with 3D inline labels.
	///
	/// The lines in the input polydata will be drawn with labels displaying the
	/// scalar value.
	///
	/// For this mapper to function properly, stenciling must be enabled in the
	/// render window (it is disabled by default). Otherwise the lines will be
	/// drawn through the labels.
	/// </remarks>
	// Token: 0x020005BB RID: 1467
	public class vtkLabeledContourMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060100DD RID: 65757 RVA: 0x0016592B File Offset: 0x00163B2B
		static vtkLabeledContourMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabeledContourMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledContourMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060100DE RID: 65758 RVA: 0x00165953 File Offset: 0x00163B53
		public vtkLabeledContourMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060100DF RID: 65759
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100E0 RID: 65760 RVA: 0x00165964 File Offset: 0x00163B64
		public new static vtkLabeledContourMapper New()
		{
			vtkLabeledContourMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100E1 RID: 65761 RVA: 0x001659B8 File Offset: 0x00163BB8
		public vtkLabeledContourMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabeledContourMapper.vtkLabeledContourMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060100E2 RID: 65762 RVA: 0x001659FC File Offset: 0x00163BFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060100E3 RID: 65763
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x060100E4 RID: 65764 RVA: 0x00165A08 File Offset: 0x00163C08
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060100E5 RID: 65765
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_GetBounds_02(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x060100E6 RID: 65766 RVA: 0x00165A50 File Offset: 0x00163C50
		public override void GetBounds(IntPtr bounds)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_GetBounds_02(base.GetCppThis(), bounds);
		}

		// Token: 0x060100E7 RID: 65767
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x060100E8 RID: 65768 RVA: 0x00165A60 File Offset: 0x00163C60
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x060100E9 RID: 65769
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkLabeledContourMapper_GetLabelVisibility_04(HandleRef pThis);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x060100EA RID: 65770 RVA: 0x00165AD0 File Offset: 0x00163CD0
		public virtual bool GetLabelVisibility()
		{
			return vtkLabeledContourMapper.vtkLabeledContourMapper_GetLabelVisibility_04(base.GetCppThis()) != 0;
		}

		// Token: 0x060100EB RID: 65771
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledContourMapper_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100EC RID: 65772 RVA: 0x00165AF8 File Offset: 0x00163CF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabeledContourMapper.vtkLabeledContourMapper_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060100ED RID: 65773
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledContourMapper_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100EE RID: 65774 RVA: 0x00165B18 File Offset: 0x00163D18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabeledContourMapper.vtkLabeledContourMapper_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060100EF RID: 65775
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_GetPolyDataMapper_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The polydata mapper used to render the contours.
		/// </summary>
		// Token: 0x060100F0 RID: 65776 RVA: 0x00165B34 File Offset: 0x00163D34
		public virtual vtkPolyDataMapper GetPolyDataMapper()
		{
			vtkPolyDataMapper vtkPolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_GetPolyDataMapper_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper = (vtkPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper.Register(null);
				}
			}
			return vtkPolyDataMapper;
		}

		// Token: 0x060100F1 RID: 65777
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkLabeledContourMapper_GetSkipDistance_08(HandleRef pThis);

		/// <summary>
		/// Ensure that there are at least SkipDistance pixels between labels. This
		/// is only enforced on labels along the same line. The default is 0.
		/// </summary>
		// Token: 0x060100F2 RID: 65778 RVA: 0x00165BA4 File Offset: 0x00163DA4
		public virtual double GetSkipDistance()
		{
			return vtkLabeledContourMapper.vtkLabeledContourMapper_GetSkipDistance_08(base.GetCppThis());
		}

		// Token: 0x060100F3 RID: 65779
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_GetTextProperties_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The text properties used to label the lines. Note that both vertical and
		/// horizontal justifications will be reset to "Centered" prior to rendering.
		///
		/// If the TextPropertyMapping array exists, then it is used to identify which
		/// text property to use for each label as follows: If the scalar value of a
		/// line is found in the mapping, the index of the value in mapping is used to
		/// lookup the text property in the collection. If there are more mapping
		/// values than properties, the properties are looped through until the
		/// mapping is exhausted.
		///
		/// Lines with scalar values missing from the mapping are assigned text
		/// properties in a round-robin fashion starting from the beginning of the
		/// collection, repeating from the start of the collection as necessary.
		/// @sa SetTextProperty
		/// @sa SetTextPropertyMapping
		/// </summary>
		// Token: 0x060100F4 RID: 65780 RVA: 0x00165BC4 File Offset: 0x00163DC4
		public virtual vtkTextPropertyCollection GetTextProperties()
		{
			vtkTextPropertyCollection vtkTextPropertyCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_GetTextProperties_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextPropertyCollection = (vtkTextPropertyCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextPropertyCollection.Register(null);
				}
			}
			return vtkTextPropertyCollection;
		}

		// Token: 0x060100F5 RID: 65781
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_GetTextPropertyMapping_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Values in this array correspond to vtkTextProperty objects in the
		/// TextProperties collection. If a contour line's scalar value exists in
		/// this array, the corresponding text property is used for the label.
		/// See SetTextProperties for more information.
		/// </summary>
		// Token: 0x060100F6 RID: 65782 RVA: 0x00165C34 File Offset: 0x00163E34
		public virtual vtkDoubleArray GetTextPropertyMapping()
		{
			vtkDoubleArray vtkDoubleArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_GetTextPropertyMapping_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDoubleArray = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDoubleArray.Register(null);
				}
			}
			return vtkDoubleArray;
		}

		// Token: 0x060100F7 RID: 65783
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledContourMapper_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100F8 RID: 65784 RVA: 0x00165CA4 File Offset: 0x00163EA4
		public override int IsA(string type)
		{
			return vtkLabeledContourMapper.vtkLabeledContourMapper_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060100F9 RID: 65785
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledContourMapper_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100FA RID: 65786 RVA: 0x00165CC4 File Offset: 0x00163EC4
		public new static int IsTypeOf(string type)
		{
			return vtkLabeledContourMapper.vtkLabeledContourMapper_IsTypeOf_12(type);
		}

		// Token: 0x060100FB RID: 65787
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_LabelVisibilityOff_13(HandleRef pThis);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x060100FC RID: 65788 RVA: 0x00165CDE File Offset: 0x00163EDE
		public virtual void LabelVisibilityOff()
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_LabelVisibilityOff_13(base.GetCppThis());
		}

		// Token: 0x060100FD RID: 65789
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_LabelVisibilityOn_14(HandleRef pThis);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x060100FE RID: 65790 RVA: 0x00165CED File Offset: 0x00163EED
		public virtual void LabelVisibilityOn()
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_LabelVisibilityOn_14(base.GetCppThis());
		}

		// Token: 0x060100FF RID: 65791
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010100 RID: 65792 RVA: 0x00165CFC File Offset: 0x00163EFC
		public new vtkLabeledContourMapper NewInstance()
		{
			vtkLabeledContourMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010101 RID: 65793
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// The polydata mapper used to render the contours.
		/// </summary>
		// Token: 0x06010102 RID: 65794 RVA: 0x00165D58 File Offset: 0x00163F58
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_ReleaseGraphicsResources_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010103 RID: 65795
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_Render_18(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010104 RID: 65796 RVA: 0x00165D88 File Offset: 0x00163F88
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_Render_18(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x06010105 RID: 65797
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledContourMapper_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010106 RID: 65798 RVA: 0x00165DCC File Offset: 0x00163FCC
		public new static vtkLabeledContourMapper SafeDownCast(vtkObjectBase o)
		{
			vtkLabeledContourMapper vtkLabeledContourMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledContourMapper.vtkLabeledContourMapper_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledContourMapper = (vtkLabeledContourMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledContourMapper.Register(null);
				}
			}
			return vtkLabeledContourMapper;
		}

		// Token: 0x06010107 RID: 65799
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_SetInputData_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the input data to map.
		/// </summary>
		// Token: 0x06010108 RID: 65800 RVA: 0x00165E4C File Offset: 0x0016404C
		public void SetInputData(vtkPolyData arg0)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_SetInputData_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010109 RID: 65801
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_SetLabelVisibility_21(HandleRef pThis, byte _arg);

		/// <summary>
		/// If true, labels will be placed and drawn during rendering. Otherwise,
		/// only the mapper returned by GetPolyDataMapper() will be rendered.
		/// The default is to draw labels.
		/// </summary>
		// Token: 0x0601010A RID: 65802 RVA: 0x00165E7B File Offset: 0x0016407B
		public virtual void SetLabelVisibility(bool _arg)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_SetLabelVisibility_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601010B RID: 65803
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_SetSkipDistance_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Ensure that there are at least SkipDistance pixels between labels. This
		/// is only enforced on labels along the same line. The default is 0.
		/// </summary>
		// Token: 0x0601010C RID: 65804 RVA: 0x00165E93 File Offset: 0x00164093
		public virtual void SetSkipDistance(double _arg)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_SetSkipDistance_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601010D RID: 65805
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_SetTextProperties_23(HandleRef pThis, HandleRef coll);

		/// <summary>
		/// The text properties used to label the lines. Note that both vertical and
		/// horizontal justifications will be reset to "Centered" prior to rendering.
		///
		/// If the TextPropertyMapping array exists, then it is used to identify which
		/// text property to use for each label as follows: If the scalar value of a
		/// line is found in the mapping, the index of the value in mapping is used to
		/// lookup the text property in the collection. If there are more mapping
		/// values than properties, the properties are looped through until the
		/// mapping is exhausted.
		///
		/// Lines with scalar values missing from the mapping are assigned text
		/// properties in a round-robin fashion starting from the beginning of the
		/// collection, repeating from the start of the collection as necessary.
		/// @sa SetTextProperty
		/// @sa SetTextPropertyMapping
		/// </summary>
		// Token: 0x0601010E RID: 65806 RVA: 0x00165EA4 File Offset: 0x001640A4
		public virtual void SetTextProperties(vtkTextPropertyCollection coll)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_SetTextProperties_23(base.GetCppThis(), (coll == null) ? default(HandleRef) : coll.GetCppThis());
		}

		// Token: 0x0601010F RID: 65807
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_SetTextProperty_24(HandleRef pThis, HandleRef tprop);

		/// <summary>
		/// The text property used to label the lines. Note that both vertical and
		/// horizontal justifications will be reset to "Centered" prior to rendering.
		/// @note This is a convenience method that clears TextProperties and inserts
		/// the argument as the only property in the collection.
		/// @sa SetTextProperties
		/// </summary>
		// Token: 0x06010110 RID: 65808 RVA: 0x00165ED4 File Offset: 0x001640D4
		public virtual void SetTextProperty(vtkTextProperty tprop)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_SetTextProperty_24(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		// Token: 0x06010111 RID: 65809
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledContourMapper_SetTextPropertyMapping_25(HandleRef pThis, HandleRef mapping);

		/// <summary>
		/// Values in this array correspond to vtkTextProperty objects in the
		/// TextProperties collection. If a contour line's scalar value exists in
		/// this array, the corresponding text property is used for the label.
		/// See SetTextProperties for more information.
		/// </summary>
		// Token: 0x06010112 RID: 65810 RVA: 0x00165F04 File Offset: 0x00164104
		public virtual void SetTextPropertyMapping(vtkDoubleArray mapping)
		{
			vtkLabeledContourMapper.vtkLabeledContourMapper_SetTextPropertyMapping_25(base.GetCppThis(), (mapping == null) ? default(HandleRef) : mapping.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B8 RID: 4792
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledContourMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B9 RID: 4793
		public new static readonly string MRClassNameKey = "class vtkLabeledContourMapper";
	}
}
