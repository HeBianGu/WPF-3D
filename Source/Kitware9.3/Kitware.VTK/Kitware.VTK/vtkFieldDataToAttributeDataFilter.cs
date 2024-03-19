using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFieldDataToAttributeDataFilter
	/// </summary>
	/// <remarks>
	///    map field data to dataset attribute data
	///
	/// vtkFieldDataToAttributeDataFilter is a class that maps field data into
	/// dataset attributes. The input to this filter is any type of dataset and
	/// the output is the same dataset (geometry/topology) with new attribute data
	/// (attribute data is passed through if not replaced during filter
	/// execution).
	///
	/// To use this filter you must specify which field data from the input
	/// dataset to use. There are three possibilities: the cell field data, the
	/// point field data, or the field data associated with the data object
	/// superclass. Then you specify which attribute data to create: either cell
	/// attribute data or point attribute data.  Finally, you must define how to
	/// construct the various attribute data types (e.g., scalars, vectors,
	/// normals, etc.) from the arrays and the components of the arrays from the
	/// field data. This is done by associating components in the input field with
	/// components making up the attribute data. For example, you would specify a
	/// scalar with three components (RGB) by assigning components from the field
	/// for the R, then G, then B values of the scalars.  You may also have to
	/// specify component ranges (for each R-G-B) to make sure that the number of
	/// R, G, and B values is the same. Also, you may want to normalize the
	/// components which helps distribute the data uniformly.
	///
	/// This filter is often used in conjunction with
	/// vtkDataObjectToDataSetFilter.  vtkDataObjectToDataSetFilter filter
	/// generates dataset topology and geometry and passes its input field data
	/// along to its output. Then this filter is used to generate the attribute
	/// data to go along with the dataset.
	///
	/// @warning
	/// Make sure that the data you extract is consistent. That is, if you have N
	/// points, extract N point attributes (scalars, vectors, etc.).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFieldData vtkDataSet vtkDataObjectToDataSetFilter
	/// vtkDataSetAttributes vtkDataArray
	/// </seealso>
	// Token: 0x02000967 RID: 2407
	public class vtkFieldDataToAttributeDataFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060190B2 RID: 102578 RVA: 0x0022ED5B File Offset: 0x0022CF5B
		static vtkFieldDataToAttributeDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFieldDataToAttributeDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFieldDataToAttributeDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060190B3 RID: 102579 RVA: 0x0022ED83 File Offset: 0x0022CF83
		public vtkFieldDataToAttributeDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060190B4 RID: 102580
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with input field set to the data object field, and the
		/// output attribute data set to generate point data.
		/// </summary>
		// Token: 0x060190B5 RID: 102581 RVA: 0x0022ED94 File Offset: 0x0022CF94
		public new static vtkFieldDataToAttributeDataFilter New()
		{
			vtkFieldDataToAttributeDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with input field set to the data object field, and the
		/// output attribute data set to generate point data.
		/// </summary>
		// Token: 0x060190B6 RID: 102582 RVA: 0x0022EDE8 File Offset: 0x0022CFE8
		public vtkFieldDataToAttributeDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060190B7 RID: 102583 RVA: 0x0022EE2C File Offset: 0x0022D02C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060190B8 RID: 102584
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_ConstructArray_01(HandleRef da, int comp, HandleRef fieldArray, int fieldComp, long min, long max, int normalize);

		/// <summary>
		/// Construct a portion of a data array (the comp portion) from another data
		/// array and its component. The variables min and max control the range of
		/// the data to use from the other data array; normalize is a flag that when
		/// set will normalize the data between (0,1).
		/// </summary>
		// Token: 0x060190B9 RID: 102585 RVA: 0x0022EE38 File Offset: 0x0022D038
		public static int ConstructArray(vtkDataArray da, int comp, vtkDataArray fieldArray, int fieldComp, long min, long max, int normalize)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_ConstructArray_01((da == null) ? default(HandleRef) : da.GetCppThis(), comp, (fieldArray == null) ? default(HandleRef) : fieldArray.GetCppThis(), fieldComp, min, max, normalize);
		}

		// Token: 0x060190BA RID: 102586
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_DefaultNormalizeOff_02(HandleRef pThis);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetScalarComponents).
		/// </summary>
		// Token: 0x060190BB RID: 102587 RVA: 0x0022EE83 File Offset: 0x0022D083
		public virtual void DefaultNormalizeOff()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_DefaultNormalizeOff_02(base.GetCppThis());
		}

		// Token: 0x060190BC RID: 102588
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_DefaultNormalizeOn_03(HandleRef pThis);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetScalarComponents).
		/// </summary>
		// Token: 0x060190BD RID: 102589 RVA: 0x0022EE92 File Offset: 0x0022D092
		public virtual void DefaultNormalizeOn()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_DefaultNormalizeOn_03(base.GetCppThis());
		}

		// Token: 0x060190BE RID: 102590
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetDefaultNormalize_04(HandleRef pThis);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetScalarComponents).
		/// </summary>
		// Token: 0x060190BF RID: 102591 RVA: 0x0022EEA4 File Offset: 0x0022D0A4
		public virtual int GetDefaultNormalize()
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetDefaultNormalize_04(base.GetCppThis());
		}

		// Token: 0x060190C0 RID: 102592
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetFieldArray_05(HandleRef fd, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int comp, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an array of a particular name from field data and do error checking.
		/// </summary>
		// Token: 0x060190C1 RID: 102593 RVA: 0x0022EEC4 File Offset: 0x0022D0C4
		public static vtkDataArray GetFieldArray(vtkFieldData fd, string name, int comp)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetFieldArray_05((fd == null) ? default(HandleRef) : fd.GetCppThis(), name, comp, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x060190C2 RID: 102594
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetInputField_06(HandleRef pThis);

		/// <summary>
		/// Specify which field data to use to generate the output attribute
		/// data. There are three choices: the field data associated with the
		/// vtkDataObject superclass; the point field attribute data; and the cell
		/// field attribute data.
		/// </summary>
		// Token: 0x060190C3 RID: 102595 RVA: 0x0022EF48 File Offset: 0x0022D148
		public virtual int GetInputField()
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetInputField_06(base.GetCppThis());
		}

		// Token: 0x060190C4 RID: 102596
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayComponent_07(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the normal
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190C5 RID: 102597 RVA: 0x0022EF68 File Offset: 0x0022D168
		public int GetNormalComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayComponent_07(base.GetCppThis(), comp);
		}

		// Token: 0x060190C6 RID: 102598
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayName_08(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the normal
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190C7 RID: 102599 RVA: 0x0022EF88 File Offset: 0x0022D188
		public string GetNormalComponentArrayName(int comp)
		{
			string s = Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentArrayName_08(base.GetCppThis(), comp));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060190C8 RID: 102600
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentMaxRange_09(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the normal
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190C9 RID: 102601 RVA: 0x0022EFC4 File Offset: 0x0022D1C4
		public int GetNormalComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentMaxRange_09(base.GetCppThis(), comp);
		}

		// Token: 0x060190CA RID: 102602
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentMinRange_10(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the normal
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190CB RID: 102603 RVA: 0x0022EFE4 File Offset: 0x0022D1E4
		public int GetNormalComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentMinRange_10(base.GetCppThis(), comp);
		}

		// Token: 0x060190CC RID: 102604
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetNormalComponentNormalizeFlag_11(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the normal
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190CD RID: 102605 RVA: 0x0022F004 File Offset: 0x0022D204
		public int GetNormalComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNormalComponentNormalizeFlag_11(base.GetCppThis(), comp);
		}

		// Token: 0x060190CE RID: 102606
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060190CF RID: 102607 RVA: 0x0022F024 File Offset: 0x0022D224
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x060190D0 RID: 102608
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060190D1 RID: 102609 RVA: 0x0022F044 File Offset: 0x0022D244
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x060190D2 RID: 102610
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetOutputAttributeData_14(HandleRef pThis);

		/// <summary>
		/// Specify which attribute data to output: point or cell data attributes.
		/// </summary>
		// Token: 0x060190D3 RID: 102611 RVA: 0x0022F060 File Offset: 0x0022D260
		public virtual int GetOutputAttributeData()
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetOutputAttributeData_14(base.GetCppThis());
		}

		// Token: 0x060190D4 RID: 102612
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayComponent_15(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the scalar
		/// components.  Note that the parameter comp must lie between (0,4). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190D5 RID: 102613 RVA: 0x0022F080 File Offset: 0x0022D280
		public int GetScalarComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayComponent_15(base.GetCppThis(), comp);
		}

		// Token: 0x060190D6 RID: 102614
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayName_16(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the scalar
		/// components.  Note that the parameter comp must lie between (0,4). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190D7 RID: 102615 RVA: 0x0022F0A0 File Offset: 0x0022D2A0
		public string GetScalarComponentArrayName(int comp)
		{
			string s = Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentArrayName_16(base.GetCppThis(), comp));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060190D8 RID: 102616
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentMaxRange_17(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the scalar
		/// components.  Note that the parameter comp must lie between (0,4). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190D9 RID: 102617 RVA: 0x0022F0DC File Offset: 0x0022D2DC
		public int GetScalarComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentMaxRange_17(base.GetCppThis(), comp);
		}

		// Token: 0x060190DA RID: 102618
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentMinRange_18(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the scalar
		/// components.  Note that the parameter comp must lie between (0,4). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190DB RID: 102619 RVA: 0x0022F0FC File Offset: 0x0022D2FC
		public int GetScalarComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentMinRange_18(base.GetCppThis(), comp);
		}

		// Token: 0x060190DC RID: 102620
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetScalarComponentNormalizeFlag_19(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the scalar
		/// components.  Note that the parameter comp must lie between (0,4). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190DD RID: 102621 RVA: 0x0022F11C File Offset: 0x0022D31C
		public int GetScalarComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetScalarComponentNormalizeFlag_19(base.GetCppThis(), comp);
		}

		// Token: 0x060190DE RID: 102622
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayComponent_20(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the cell texture coord
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190DF RID: 102623 RVA: 0x0022F13C File Offset: 0x0022D33C
		public int GetTCoordComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayComponent_20(base.GetCppThis(), comp);
		}

		// Token: 0x060190E0 RID: 102624
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayName_21(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the cell texture coord
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190E1 RID: 102625 RVA: 0x0022F15C File Offset: 0x0022D35C
		public string GetTCoordComponentArrayName(int comp)
		{
			string s = Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentArrayName_21(base.GetCppThis(), comp));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060190E2 RID: 102626
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentMaxRange_22(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the cell texture coord
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190E3 RID: 102627 RVA: 0x0022F198 File Offset: 0x0022D398
		public int GetTCoordComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentMaxRange_22(base.GetCppThis(), comp);
		}

		// Token: 0x060190E4 RID: 102628
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentMinRange_23(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the cell texture coord
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190E5 RID: 102629 RVA: 0x0022F1B8 File Offset: 0x0022D3B8
		public int GetTCoordComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentMinRange_23(base.GetCppThis(), comp);
		}

		// Token: 0x060190E6 RID: 102630
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTCoordComponentNormalizeFlag_24(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the cell texture coord
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190E7 RID: 102631 RVA: 0x0022F1D8 File Offset: 0x0022D3D8
		public int GetTCoordComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTCoordComponentNormalizeFlag_24(base.GetCppThis(), comp);
		}

		// Token: 0x060190E8 RID: 102632
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayComponent_25(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the tensor
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190E9 RID: 102633 RVA: 0x0022F1F8 File Offset: 0x0022D3F8
		public int GetTensorComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayComponent_25(base.GetCppThis(), comp);
		}

		// Token: 0x060190EA RID: 102634
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayName_26(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the tensor
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190EB RID: 102635 RVA: 0x0022F218 File Offset: 0x0022D418
		public string GetTensorComponentArrayName(int comp)
		{
			string s = Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentArrayName_26(base.GetCppThis(), comp));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060190EC RID: 102636
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentMaxRange_27(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the tensor
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190ED RID: 102637 RVA: 0x0022F254 File Offset: 0x0022D454
		public int GetTensorComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentMaxRange_27(base.GetCppThis(), comp);
		}

		// Token: 0x060190EE RID: 102638
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentMinRange_28(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the tensor
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190EF RID: 102639 RVA: 0x0022F274 File Offset: 0x0022D474
		public int GetTensorComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentMinRange_28(base.GetCppThis(), comp);
		}

		// Token: 0x060190F0 RID: 102640
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetTensorComponentNormalizeFlag_29(HandleRef pThis, int comp);

		/// <summary>
		/// Define the components of the field to be used for the tensor
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190F1 RID: 102641 RVA: 0x0022F294 File Offset: 0x0022D494
		public int GetTensorComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetTensorComponentNormalizeFlag_29(base.GetCppThis(), comp);
		}

		// Token: 0x060190F2 RID: 102642
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayComponent_30(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the vector
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190F3 RID: 102643 RVA: 0x0022F2B4 File Offset: 0x0022D4B4
		public int GetVectorComponentArrayComponent(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayComponent_30(base.GetCppThis(), comp);
		}

		// Token: 0x060190F4 RID: 102644
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayName_31(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the vector
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190F5 RID: 102645 RVA: 0x0022F2D4 File Offset: 0x0022D4D4
		public string GetVectorComponentArrayName(int comp)
		{
			string s = Marshal.PtrToStringAnsi(vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentArrayName_31(base.GetCppThis(), comp));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060190F6 RID: 102646
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentMaxRange_32(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the vector
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190F7 RID: 102647 RVA: 0x0022F310 File Offset: 0x0022D510
		public int GetVectorComponentMaxRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentMaxRange_32(base.GetCppThis(), comp);
		}

		// Token: 0x060190F8 RID: 102648
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentMinRange_33(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the vector
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190F9 RID: 102649 RVA: 0x0022F330 File Offset: 0x0022D530
		public int GetVectorComponentMinRange(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentMinRange_33(base.GetCppThis(), comp);
		}

		// Token: 0x060190FA RID: 102650
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_GetVectorComponentNormalizeFlag_34(HandleRef pThis, int comp);

		/// <summary>
		/// Define the component(s) of the field to be used for the vector
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x060190FB RID: 102651 RVA: 0x0022F350 File Offset: 0x0022D550
		public int GetVectorComponentNormalizeFlag(int comp)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_GetVectorComponentNormalizeFlag_34(base.GetCppThis(), comp);
		}

		// Token: 0x060190FC RID: 102652
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_IsA_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060190FD RID: 102653 RVA: 0x0022F370 File Offset: 0x0022D570
		public override int IsA(string type)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_IsA_35(base.GetCppThis(), type);
		}

		// Token: 0x060190FE RID: 102654
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_IsTypeOf_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060190FF RID: 102655 RVA: 0x0022F390 File Offset: 0x0022D590
		public new static int IsTypeOf(string type)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_IsTypeOf_36(type);
		}

		// Token: 0x06019100 RID: 102656
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019101 RID: 102657 RVA: 0x0022F3AC File Offset: 0x0022D5AC
		public new vtkFieldDataToAttributeDataFilter NewInstance()
		{
			vtkFieldDataToAttributeDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_NewInstance_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019102 RID: 102658
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFieldDataToAttributeDataFilter_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019103 RID: 102659 RVA: 0x0022F408 File Offset: 0x0022D608
		public new static vtkFieldDataToAttributeDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkFieldDataToAttributeDataFilter vtkFieldDataToAttributeDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldDataToAttributeDataFilter = (vtkFieldDataToAttributeDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldDataToAttributeDataFilter.Register(null);
				}
			}
			return vtkFieldDataToAttributeDataFilter;
		}

		// Token: 0x06019104 RID: 102660
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetDefaultNormalize_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the default Normalize() flag for those methods setting a default
		/// Normalize value (e.g., SetScalarComponents).
		/// </summary>
		// Token: 0x06019105 RID: 102661 RVA: 0x0022F487 File Offset: 0x0022D687
		public virtual void SetDefaultNormalize(int _arg)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetDefaultNormalize_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06019106 RID: 102662
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputField_41(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify which field data to use to generate the output attribute
		/// data. There are three choices: the field data associated with the
		/// vtkDataObject superclass; the point field attribute data; and the cell
		/// field attribute data.
		/// </summary>
		// Token: 0x06019107 RID: 102663 RVA: 0x0022F497 File Offset: 0x0022D697
		public virtual void SetInputField(int _arg)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputField_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06019108 RID: 102664
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToCellDataField_42(HandleRef pThis);

		/// <summary>
		/// Specify which field data to use to generate the output attribute
		/// data. There are three choices: the field data associated with the
		/// vtkDataObject superclass; the point field attribute data; and the cell
		/// field attribute data.
		/// </summary>
		// Token: 0x06019109 RID: 102665 RVA: 0x0022F4A7 File Offset: 0x0022D6A7
		public void SetInputFieldToCellDataField()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputFieldToCellDataField_42(base.GetCppThis());
		}

		// Token: 0x0601910A RID: 102666
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToDataObjectField_43(HandleRef pThis);

		/// <summary>
		/// Specify which field data to use to generate the output attribute
		/// data. There are three choices: the field data associated with the
		/// vtkDataObject superclass; the point field attribute data; and the cell
		/// field attribute data.
		/// </summary>
		// Token: 0x0601910B RID: 102667 RVA: 0x0022F4B6 File Offset: 0x0022D6B6
		public void SetInputFieldToDataObjectField()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputFieldToDataObjectField_43(base.GetCppThis());
		}

		// Token: 0x0601910C RID: 102668
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetInputFieldToPointDataField_44(HandleRef pThis);

		/// <summary>
		/// Specify which field data to use to generate the output attribute
		/// data. There are three choices: the field data associated with the
		/// vtkDataObject superclass; the point field attribute data; and the cell
		/// field attribute data.
		/// </summary>
		// Token: 0x0601910D RID: 102669 RVA: 0x0022F4C5 File Offset: 0x0022D6C5
		public void SetInputFieldToPointDataField()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetInputFieldToPointDataField_44(base.GetCppThis());
		}

		// Token: 0x0601910E RID: 102670
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetNormalComponent_45(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max, int normalize);

		/// <summary>
		/// Define the component(s) of the field to be used for the normal
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x0601910F RID: 102671 RVA: 0x0022F4D4 File Offset: 0x0022D6D4
		public void SetNormalComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetNormalComponent_45(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		// Token: 0x06019110 RID: 102672
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetNormalComponent_46(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define the component(s) of the field to be used for the normal
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x06019111 RID: 102673 RVA: 0x0022F4EC File Offset: 0x0022D6EC
		public void SetNormalComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetNormalComponent_46(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		// Token: 0x06019112 RID: 102674
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeData_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify which attribute data to output: point or cell data attributes.
		/// </summary>
		// Token: 0x06019113 RID: 102675 RVA: 0x0022F4FE File Offset: 0x0022D6FE
		public virtual void SetOutputAttributeData(int _arg)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetOutputAttributeData_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06019114 RID: 102676
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToCellData_48(HandleRef pThis);

		/// <summary>
		/// Specify which attribute data to output: point or cell data attributes.
		/// </summary>
		// Token: 0x06019115 RID: 102677 RVA: 0x0022F50E File Offset: 0x0022D70E
		public void SetOutputAttributeDataToCellData()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToCellData_48(base.GetCppThis());
		}

		// Token: 0x06019116 RID: 102678
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToPointData_49(HandleRef pThis);

		/// <summary>
		/// Specify which attribute data to output: point or cell data attributes.
		/// </summary>
		// Token: 0x06019117 RID: 102679 RVA: 0x0022F51D File Offset: 0x0022D71D
		public void SetOutputAttributeDataToPointData()
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetOutputAttributeDataToPointData_49(base.GetCppThis());
		}

		// Token: 0x06019118 RID: 102680
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetScalarComponent_50(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max, int normalize);

		/// <summary>
		/// Define the component(s) of the field to be used for the scalar
		/// components.  Note that the parameter comp must lie between (0,4). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x06019119 RID: 102681 RVA: 0x0022F52C File Offset: 0x0022D72C
		public void SetScalarComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetScalarComponent_50(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		// Token: 0x0601911A RID: 102682
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetScalarComponent_51(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define the component(s) of the field to be used for the scalar
		/// components.  Note that the parameter comp must lie between (0,4). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x0601911B RID: 102683 RVA: 0x0022F544 File Offset: 0x0022D744
		public void SetScalarComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetScalarComponent_51(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		// Token: 0x0601911C RID: 102684
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTCoordComponent_52(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max, int normalize);

		/// <summary>
		/// Define the components of the field to be used for the cell texture coord
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x0601911D RID: 102685 RVA: 0x0022F556 File Offset: 0x0022D756
		public void SetTCoordComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTCoordComponent_52(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		// Token: 0x0601911E RID: 102686
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTCoordComponent_53(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define the components of the field to be used for the cell texture coord
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x0601911F RID: 102687 RVA: 0x0022F56E File Offset: 0x0022D76E
		public void SetTCoordComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTCoordComponent_53(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		// Token: 0x06019120 RID: 102688
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTensorComponent_54(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max, int normalize);

		/// <summary>
		/// Define the components of the field to be used for the tensor
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x06019121 RID: 102689 RVA: 0x0022F580 File Offset: 0x0022D780
		public void SetTensorComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTensorComponent_54(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		// Token: 0x06019122 RID: 102690
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetTensorComponent_55(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define the components of the field to be used for the tensor
		/// components.  Note that the parameter comp must lie between (0,9). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x06019123 RID: 102691 RVA: 0x0022F598 File Offset: 0x0022D798
		public void SetTensorComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetTensorComponent_55(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		// Token: 0x06019124 RID: 102692
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetVectorComponent_56(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp, int min, int max, int normalize);

		/// <summary>
		/// Define the component(s) of the field to be used for the vector
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x06019125 RID: 102693 RVA: 0x0022F5AA File Offset: 0x0022D7AA
		public void SetVectorComponent(int comp, string arrayName, int arrayComp, int min, int max, int normalize)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetVectorComponent_56(base.GetCppThis(), comp, arrayName, arrayComp, min, max, normalize);
		}

		// Token: 0x06019126 RID: 102694
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFieldDataToAttributeDataFilter_SetVectorComponent_57(HandleRef pThis, int comp, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrayName, int arrayComp);

		/// <summary>
		/// Define the component(s) of the field to be used for the vector
		/// components.  Note that the parameter comp must lie between (0,3). To
		/// define the field component to use you specify an array name and the
		/// component in that array. The (min,max) values are the range of data in
		/// the component you wish to extract.
		/// </summary>
		// Token: 0x06019127 RID: 102695 RVA: 0x0022F5C2 File Offset: 0x0022D7C2
		public void SetVectorComponent(int comp, string arrayName, int arrayComp)
		{
			vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_SetVectorComponent_57(base.GetCppThis(), comp, arrayName, arrayComp);
		}

		// Token: 0x06019128 RID: 102696
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFieldDataToAttributeDataFilter_UpdateComponentRange_58(HandleRef da, IntPtr compRange);

		/// <summary>
		/// Update the maximum and minimum component range values. Returns a flag
		/// indicating whether the range was updated.
		/// </summary>
		// Token: 0x06019129 RID: 102697 RVA: 0x0022F5D4 File Offset: 0x0022D7D4
		public static int UpdateComponentRange(vtkDataArray da, IntPtr compRange)
		{
			return vtkFieldDataToAttributeDataFilter.vtkFieldDataToAttributeDataFilter_UpdateComponentRange_58((da == null) ? default(HandleRef) : da.GetCppThis(), compRange);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B87 RID: 7047
		public new const string MRFullTypeName = "Kitware.VTK.vtkFieldDataToAttributeDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B88 RID: 7048
		public new static readonly string MRClassNameKey = "class vtkFieldDataToAttributeDataFilter";
	}
}
