using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLabeledDataMapper
	/// </summary>
	/// <remarks>
	///    draw text labels at dataset points
	///
	/// vtkLabeledDataMapper is a mapper that renders text at dataset
	/// points. Various items can be labeled including point ids, scalars,
	/// vectors, normals, texture coordinates, tensors, and field data components.
	///
	/// The format with which the label is drawn is specified using a
	/// printf style format string. The font attributes of the text can
	/// be set through the vtkTextProperty associated to this mapper.
	///
	/// By default, all the components of multi-component data such as
	/// vectors, normals, texture coordinates, tensors, and multi-component
	/// scalars are labeled. However, you can specify a single component if
	/// you prefer. (Note: the label format specifies the format to use for
	/// a single component. The label is creating by looping over all components
	/// and using the label format to render each component.)
	/// The character separator between components can be set. By default,
	/// it is set to a single whitespace.
	///
	/// @warning
	/// Use this filter in combination with vtkSelectVisiblePoints if you want
	/// to label only points that are visible. If you want to label cells rather
	/// than points, use the filter vtkCellCenters to generate points at the
	/// center of the cells. Also, you can use the class vtkIdFilter to
	/// generate ids as scalars or field data, which can then be labeled.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMapper2D vtkActor2D vtkTextMapper vtkTextProperty vtkSelectVisiblePoints
	/// vtkIdFilter vtkCellCenters
	/// </seealso>
	// Token: 0x020000E2 RID: 226
	public class vtkLabeledDataMapper : vtkMapper2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002F0C RID: 12044 RVA: 0x00044DD3 File Offset: 0x00042FD3
		static vtkLabeledDataMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabeledDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabeledDataMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002F0D RID: 12045 RVA: 0x00044DFB File Offset: 0x00042FFB
		public vtkLabeledDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06002F0E RID: 12046
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F0F RID: 12047 RVA: 0x00044E0C File Offset: 0x0004300C
		public new static vtkLabeledDataMapper New()
		{
			vtkLabeledDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F10 RID: 12048 RVA: 0x00044E60 File Offset: 0x00043060
		public vtkLabeledDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLabeledDataMapper.vtkLabeledDataMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002F11 RID: 12049 RVA: 0x00044EA4 File Offset: 0x000430A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06002F12 RID: 12050
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_CoordinateSystemDisplay_01(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06002F13 RID: 12051 RVA: 0x00044EAF File Offset: 0x000430AF
		public void CoordinateSystemDisplay()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_CoordinateSystemDisplay_01(base.GetCppThis());
		}

		// Token: 0x06002F14 RID: 12052
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_CoordinateSystemWorld_02(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06002F15 RID: 12053 RVA: 0x00044EBE File Offset: 0x000430BE
		public void CoordinateSystemWorld()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_CoordinateSystemWorld_02(base.GetCppThis());
		}

		// Token: 0x06002F16 RID: 12054
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkLabeledDataMapper_GetComponentSeparator_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the separator between components.
		/// </summary>
		// Token: 0x06002F17 RID: 12055 RVA: 0x00044ED0 File Offset: 0x000430D0
		public virtual sbyte GetComponentSeparator()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetComponentSeparator_03(base.GetCppThis());
		}

		// Token: 0x06002F18 RID: 12056
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_GetCoordinateSystem_04(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06002F19 RID: 12057 RVA: 0x00044EF0 File Offset: 0x000430F0
		public virtual int GetCoordinateSystem()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetCoordinateSystem_04(base.GetCppThis());
		}

		// Token: 0x06002F1A RID: 12058
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_GetCoordinateSystemMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06002F1B RID: 12059 RVA: 0x00044F10 File Offset: 0x00043110
		public virtual int GetCoordinateSystemMaxValue()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetCoordinateSystemMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06002F1C RID: 12060
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_GetCoordinateSystemMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06002F1D RID: 12061 RVA: 0x00044F30 File Offset: 0x00043130
		public virtual int GetCoordinateSystemMinValue()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetCoordinateSystemMinValue_06(base.GetCppThis());
		}

		// Token: 0x06002F1E RID: 12062
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_GetFieldDataArray_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the field data array to label. This instance variable is
		/// only applicable if field data is labeled.  This will clear
		/// FieldDataName when set.
		/// </summary>
		// Token: 0x06002F1F RID: 12063 RVA: 0x00044F50 File Offset: 0x00043150
		public virtual int GetFieldDataArray()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetFieldDataArray_07(base.GetCppThis());
		}

		// Token: 0x06002F20 RID: 12064
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_GetFieldDataName_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the field data array to label.  This instance
		/// variable is only applicable if field data is labeled.  This will
		/// override FieldDataArray when set.
		/// </summary>
		// Token: 0x06002F21 RID: 12065 RVA: 0x00044F70 File Offset: 0x00043170
		public virtual string GetFieldDataName()
		{
			string s = Marshal.PtrToStringAnsi(vtkLabeledDataMapper.vtkLabeledDataMapper_GetFieldDataName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06002F22 RID: 12066
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_GetInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Use GetInputDataObject() to get the input data object for composite
		/// datasets.
		/// </summary>
		// Token: 0x06002F23 RID: 12067 RVA: 0x00044FAC File Offset: 0x000431AC
		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetInput_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x06002F24 RID: 12068
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_GetLabelFormat_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels.  This should
		/// be a printf-style format string.
		///
		/// By default, the mapper will try to print each component of the
		/// tuple using a sane format: %d for integers, %f for floats, %g for
		/// doubles, %ld for longs, et cetera.  If you need a different
		/// format, set it here.  You can do things like limit the number of
		/// significant digits, add prefixes/suffixes, basically anything
		/// that printf can do.  If you only want to print one component of a
		/// vector, see the ivar LabeledComponent.
		/// </summary>
		// Token: 0x06002F25 RID: 12069 RVA: 0x0004501C File Offset: 0x0004321C
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelFormat_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06002F26 RID: 12070
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_GetLabelMode_11(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F27 RID: 12071 RVA: 0x00045058 File Offset: 0x00043258
		public virtual int GetLabelMode()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelMode_11(base.GetCppThis());
		}

		// Token: 0x06002F28 RID: 12072
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_GetLabelPosition_12(HandleRef pThis, int label, IntPtr pos);

		/// <summary>
		/// Return the position of the requested label.
		/// </summary>
		// Token: 0x06002F29 RID: 12073 RVA: 0x00045077 File Offset: 0x00043277
		public void GetLabelPosition(int label, IntPtr pos)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelPosition_12(base.GetCppThis(), label, pos);
		}

		// Token: 0x06002F2A RID: 12074
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_GetLabelText_13(HandleRef pThis, int label);

		/// <summary>
		/// Return the text for the requested label.
		/// </summary>
		// Token: 0x06002F2B RID: 12075 RVA: 0x00045088 File Offset: 0x00043288
		public string GetLabelText(int label)
		{
			string s = Marshal.PtrToStringAnsi(vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelText_13(base.GetCppThis(), label));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06002F2C RID: 12076
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_GetLabelTextProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property.
		/// If an integer argument is provided, you may provide different text
		/// properties for different label types. The type is determined by an
		/// optional type input array.
		/// </summary>
		// Token: 0x06002F2D RID: 12077 RVA: 0x000450C4 File Offset: 0x000432C4
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelTextProperty_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002F2E RID: 12078
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_GetLabelTextProperty_15(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the text property.
		/// If an integer argument is provided, you may provide different text
		/// properties for different label types. The type is determined by an
		/// optional type input array.
		/// </summary>
		// Token: 0x06002F2F RID: 12079 RVA: 0x00045134 File Offset: 0x00043334
		public virtual vtkTextProperty GetLabelTextProperty(int type)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabelTextProperty_15(base.GetCppThis(), type, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002F30 RID: 12080
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_GetLabeledComponent_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the component number to label if the data to print has
		/// more than one component. For example, all the components of
		/// scalars, vectors, normals, etc. are labeled by default
		/// (LabeledComponent=(-1)). However, if this ivar is nonnegative,
		/// then only the one component specified is labeled.
		/// </summary>
		// Token: 0x06002F31 RID: 12081 RVA: 0x000451A4 File Offset: 0x000433A4
		public virtual int GetLabeledComponent()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetLabeledComponent_16(base.GetCppThis());
		}

		// Token: 0x06002F32 RID: 12082
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLabeledDataMapper_GetMTime_17(HandleRef pThis);

		/// <summary>
		/// Return the modified time for this object.
		/// </summary>
		// Token: 0x06002F33 RID: 12083 RVA: 0x000451C4 File Offset: 0x000433C4
		public override ulong GetMTime()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetMTime_17(base.GetCppThis());
		}

		// Token: 0x06002F34 RID: 12084
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledDataMapper_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F35 RID: 12085 RVA: 0x000451E4 File Offset: 0x000433E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06002F36 RID: 12086
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLabeledDataMapper_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F37 RID: 12087 RVA: 0x00045204 File Offset: 0x00043404
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06002F38 RID: 12088
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_GetNumberOfLabels_20(HandleRef pThis);

		/// <summary>
		/// Return the number of labels rendered by the mapper.
		/// </summary>
		// Token: 0x06002F39 RID: 12089 RVA: 0x00045220 File Offset: 0x00043420
		public virtual int GetNumberOfLabels()
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_GetNumberOfLabels_20(base.GetCppThis());
		}

		// Token: 0x06002F3A RID: 12090
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_GetTransform_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The transform to apply to the labels before mapping to 2D.
		/// </summary>
		// Token: 0x06002F3B RID: 12091 RVA: 0x00045240 File Offset: 0x00043440
		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_GetTransform_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x06002F3C RID: 12092
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F3D RID: 12093 RVA: 0x000452B0 File Offset: 0x000434B0
		public override int IsA(string type)
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06002F3E RID: 12094
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLabeledDataMapper_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F3F RID: 12095 RVA: 0x000452D0 File Offset: 0x000434D0
		public new static int IsTypeOf(string type)
		{
			return vtkLabeledDataMapper.vtkLabeledDataMapper_IsTypeOf_23(type);
		}

		// Token: 0x06002F40 RID: 12096
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F41 RID: 12097 RVA: 0x000452EC File Offset: 0x000434EC
		public new vtkLabeledDataMapper NewInstance()
		{
			vtkLabeledDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06002F42 RID: 12098
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// </summary>
		// Token: 0x06002F43 RID: 12099 RVA: 0x00045348 File Offset: 0x00043548
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_ReleaseGraphicsResources_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002F44 RID: 12100
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw the text to the screen at each input point.
		/// </summary>
		// Token: 0x06002F45 RID: 12101 RVA: 0x00045378 File Offset: 0x00043578
		public override void RenderOpaqueGeometry(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_RenderOpaqueGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06002F46 RID: 12102
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_RenderOverlay_28(HandleRef pThis, HandleRef viewport, HandleRef actor);

		/// <summary>
		/// Draw the text to the screen at each input point.
		/// </summary>
		// Token: 0x06002F47 RID: 12103 RVA: 0x000453BC File Offset: 0x000435BC
		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_RenderOverlay_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		// Token: 0x06002F48 RID: 12104
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLabeledDataMapper_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with %%-#6.3g label format. By default, point ids
		/// are labeled.
		/// </summary>
		// Token: 0x06002F49 RID: 12105 RVA: 0x00045400 File Offset: 0x00043600
		public new static vtkLabeledDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkLabeledDataMapper vtkLabeledDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLabeledDataMapper.vtkLabeledDataMapper_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabeledDataMapper = (vtkLabeledDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabeledDataMapper.Register(null);
				}
			}
			return vtkLabeledDataMapper;
		}

		// Token: 0x06002F4A RID: 12106
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetComponentSeparator_30(HandleRef pThis, sbyte _arg);

		/// <summary>
		/// Set/Get the separator between components.
		/// </summary>
		// Token: 0x06002F4B RID: 12107 RVA: 0x0004547F File Offset: 0x0004367F
		public virtual void SetComponentSeparator(sbyte _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetComponentSeparator_30(base.GetCppThis(), _arg);
		}

		// Token: 0x06002F4C RID: 12108
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetCoordinateSystem_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the coordinate system used for output labels.
		/// The output datasets may have point coordinates reported in the world space or display space.
		/// </summary>
		// Token: 0x06002F4D RID: 12109 RVA: 0x0004548F File Offset: 0x0004368F
		public virtual void SetCoordinateSystem(int _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetCoordinateSystem_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06002F4E RID: 12110
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetFieldDataArray_32(HandleRef pThis, int arrayIndex);

		/// <summary>
		/// Set/Get the field data array to label. This instance variable is
		/// only applicable if field data is labeled.  This will clear
		/// FieldDataName when set.
		/// </summary>
		// Token: 0x06002F4F RID: 12111 RVA: 0x0004549F File Offset: 0x0004369F
		public void SetFieldDataArray(int arrayIndex)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetFieldDataArray_32(base.GetCppThis(), arrayIndex);
		}

		// Token: 0x06002F50 RID: 12112
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetFieldDataName_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName);

		/// <summary>
		/// Set/Get the name of the field data array to label.  This instance
		/// variable is only applicable if field data is labeled.  This will
		/// override FieldDataArray when set.
		/// </summary>
		// Token: 0x06002F51 RID: 12113 RVA: 0x000454AF File Offset: 0x000436AF
		public void SetFieldDataName(string arrayName)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetFieldDataName_33(base.GetCppThis(), arrayName);
		}

		// Token: 0x06002F52 RID: 12114
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetInputData_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input dataset to the mapper. This mapper handles any type of data.
		/// </summary>
		// Token: 0x06002F53 RID: 12115 RVA: 0x000454C0 File Offset: 0x000436C0
		public virtual void SetInputData(vtkDataObject arg0)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetInputData_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06002F54 RID: 12116
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelFormat_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels.  This should
		/// be a printf-style format string.
		///
		/// By default, the mapper will try to print each component of the
		/// tuple using a sane format: %d for integers, %f for floats, %g for
		/// doubles, %ld for longs, et cetera.  If you need a different
		/// format, set it here.  You can do things like limit the number of
		/// significant digits, add prefixes/suffixes, basically anything
		/// that printf can do.  If you only want to print one component of a
		/// vector, see the ivar LabeledComponent.
		/// </summary>
		// Token: 0x06002F55 RID: 12117 RVA: 0x000454EF File Offset: 0x000436EF
		public virtual void SetLabelFormat(string _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelFormat_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06002F56 RID: 12118
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelMode_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F57 RID: 12119 RVA: 0x000454FF File Offset: 0x000436FF
		public virtual void SetLabelMode(int _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelMode_36(base.GetCppThis(), _arg);
		}

		// Token: 0x06002F58 RID: 12120
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelFieldData_37(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F59 RID: 12121 RVA: 0x0004550F File Offset: 0x0004370F
		public void SetLabelModeToLabelFieldData()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelFieldData_37(base.GetCppThis());
		}

		// Token: 0x06002F5A RID: 12122
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelIds_38(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F5B RID: 12123 RVA: 0x0004551E File Offset: 0x0004371E
		public void SetLabelModeToLabelIds()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelIds_38(base.GetCppThis());
		}

		// Token: 0x06002F5C RID: 12124
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelNormals_39(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F5D RID: 12125 RVA: 0x0004552D File Offset: 0x0004372D
		public void SetLabelModeToLabelNormals()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelNormals_39(base.GetCppThis());
		}

		// Token: 0x06002F5E RID: 12126
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelScalars_40(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F5F RID: 12127 RVA: 0x0004553C File Offset: 0x0004373C
		public void SetLabelModeToLabelScalars()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelScalars_40(base.GetCppThis());
		}

		// Token: 0x06002F60 RID: 12128
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelTCoords_41(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F61 RID: 12129 RVA: 0x0004554B File Offset: 0x0004374B
		public void SetLabelModeToLabelTCoords()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelTCoords_41(base.GetCppThis());
		}

		// Token: 0x06002F62 RID: 12130
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelTensors_42(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F63 RID: 12131 RVA: 0x0004555A File Offset: 0x0004375A
		public void SetLabelModeToLabelTensors()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelTensors_42(base.GetCppThis());
		}

		// Token: 0x06002F64 RID: 12132
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelModeToLabelVectors_43(HandleRef pThis);

		/// <summary>
		/// Specify which data to plot: IDs, scalars, vectors, normals, texture coords,
		/// tensors, or field data. If the data has more than one component, use
		/// the method SetLabeledComponent to control which components to plot.
		/// The default is VTK_LABEL_IDS.
		/// </summary>
		// Token: 0x06002F65 RID: 12133 RVA: 0x00045569 File Offset: 0x00043769
		public void SetLabelModeToLabelVectors()
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelModeToLabelVectors_43(base.GetCppThis());
		}

		// Token: 0x06002F66 RID: 12134
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelTextProperty_44(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the text property.
		/// If an integer argument is provided, you may provide different text
		/// properties for different label types. The type is determined by an
		/// optional type input array.
		/// </summary>
		// Token: 0x06002F67 RID: 12135 RVA: 0x00045578 File Offset: 0x00043778
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelTextProperty_44(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x06002F68 RID: 12136
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabelTextProperty_45(HandleRef pThis, HandleRef p, int type);

		/// <summary>
		/// Set/Get the text property.
		/// If an integer argument is provided, you may provide different text
		/// properties for different label types. The type is determined by an
		/// optional type input array.
		/// </summary>
		// Token: 0x06002F69 RID: 12137 RVA: 0x000455A8 File Offset: 0x000437A8
		public virtual void SetLabelTextProperty(vtkTextProperty p, int type)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabelTextProperty_45(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), type);
		}

		// Token: 0x06002F6A RID: 12138
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetLabeledComponent_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the component number to label if the data to print has
		/// more than one component. For example, all the components of
		/// scalars, vectors, normals, etc. are labeled by default
		/// (LabeledComponent=(-1)). However, if this ivar is nonnegative,
		/// then only the one component specified is labeled.
		/// </summary>
		// Token: 0x06002F6B RID: 12139 RVA: 0x000455D8 File Offset: 0x000437D8
		public virtual void SetLabeledComponent(int _arg)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetLabeledComponent_46(base.GetCppThis(), _arg);
		}

		// Token: 0x06002F6C RID: 12140
		[DllImport("Kitware.VTK.RenderingLabel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLabeledDataMapper_SetTransform_47(HandleRef pThis, HandleRef t);

		/// <summary>
		/// The transform to apply to the labels before mapping to 2D.
		/// </summary>
		// Token: 0x06002F6D RID: 12141 RVA: 0x000455E8 File Offset: 0x000437E8
		public void SetTransform(vtkTransform t)
		{
			vtkLabeledDataMapper.vtkLabeledDataMapper_SetTransform_47(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005C8 RID: 1480
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabeledDataMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040005C9 RID: 1481
		public new static readonly string MRClassNameKey = "class vtkLabeledDataMapper";

		/// <summary>
		/// The transform to apply to the labels before mapping to 2D.
		/// </summary>
		// Token: 0x020000E3 RID: 227
		public enum Coordinates
		{
			/// <summary>enum member</summary>
			// Token: 0x040005CB RID: 1483
			DISPLAY = 1,
			/// <summary>enum member</summary>
			// Token: 0x040005CC RID: 1484
			WORLD = 0
		}
	}
}
