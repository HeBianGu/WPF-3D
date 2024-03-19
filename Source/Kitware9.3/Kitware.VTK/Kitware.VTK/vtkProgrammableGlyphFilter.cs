using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgrammableGlyphFilter
	/// </summary>
	/// <remarks>
	///    control the generation and placement of glyphs at input points
	///
	/// vtkProgrammableGlyphFilter is a filter that allows you to place a glyph at
	/// each input point in the dataset. In addition, the filter is programmable
	/// which means the user has control over the generation of the glyph. The
	/// glyphs can be controlled via the point data attributes (e.g., scalars,
	/// vectors, etc.) or any other information in the input dataset.
	///
	/// This is the way the filter works. You must define an input dataset which
	/// at a minimum contains points with associated attribute values. Also, the
	/// Source instance variable must be set which is of type vtkPolyData. Then,
	/// for each point in the input, the PointId is set to the current point id,
	/// and a user-defined function is called (i.e., GlyphMethod). In this method
	/// you can manipulate the Source data (including changing to a different
	/// Source object). After the GlyphMethod is called,
	/// vtkProgrammableGlyphFilter will invoke an Update() on its Source object,
	/// and then copy its data to the output of the
	/// vtkProgrammableGlyphFilter. Therefore the output of this filter is of type
	/// vtkPolyData.
	///
	/// Another option to this filter is the way you color the glyphs. You can use
	/// the scalar data from the input or the source. The instance variable
	/// ColorMode controls this behavior.
	///
	/// @warning
	/// This filter operates on point data attributes. If you want to use cell
	/// data attributes, use a filter like vtkCellCenters to generate points at
	/// the centers of cells, and then use these points.
	///
	/// @warning
	/// Note that the data attributes (cell and point) are passed to the output of
	/// this filter from the Source object. This works well as long as you are not
	/// changing the class of the Source object during execution. However, if the
	/// class of the Source object changes, then the potential exists that the
	/// data attributes might change during execution (e.g., scalars available
	/// from one source and not the next), possibly fouling up the copying of data
	/// attributes to the output. In this case, you may have to manually set the
	/// output's copy flags (e.g., CopyScalarsOn/Off(), CopyVectorsOn/Off(), etc.)
	/// to control what's being copied.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGlyph3D vtkTensorGlyph vtkCellCenters
	/// </seealso>
	// Token: 0x02000431 RID: 1073
	public class vtkProgrammableGlyphFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C8D2 RID: 51410 RVA: 0x00117BDC File Offset: 0x00115DDC
		static vtkProgrammableGlyphFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgrammableGlyphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgrammableGlyphFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C8D3 RID: 51411 RVA: 0x00117C04 File Offset: 0x00115E04
		public vtkProgrammableGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C8D4 RID: 51412
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with nullptr GlyphMethod() and no source object. The ColorMode
		/// is set to color by the input.
		/// </summary>
		// Token: 0x0600C8D5 RID: 51413 RVA: 0x00117C14 File Offset: 0x00115E14
		public new static vtkProgrammableGlyphFilter New()
		{
			vtkProgrammableGlyphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with nullptr GlyphMethod() and no source object. The ColorMode
		/// is set to color by the input.
		/// </summary>
		// Token: 0x0600C8D6 RID: 51414 RVA: 0x00117C68 File Offset: 0x00115E68
		public vtkProgrammableGlyphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C8D7 RID: 51415 RVA: 0x00117CAC File Offset: 0x00115EAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C8D8 RID: 51416
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableGlyphFilter_GetColorMode_01(HandleRef pThis);

		/// <summary>
		/// Either color by the input or source scalar data.
		/// </summary>
		// Token: 0x0600C8D9 RID: 51417 RVA: 0x00117CB8 File Offset: 0x00115EB8
		public virtual int GetColorMode()
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetColorMode_01(base.GetCppThis());
		}

		// Token: 0x0600C8DA RID: 51418
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetColorModeAsString_02(HandleRef pThis);

		/// <summary>
		/// Either color by the input or source scalar data.
		/// </summary>
		// Token: 0x0600C8DB RID: 51419 RVA: 0x00117CD8 File Offset: 0x00115ED8
		public string GetColorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetColorModeAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600C8DC RID: 51420
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8DD RID: 51421 RVA: 0x00117D14 File Offset: 0x00115F14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C8DE RID: 51422
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8DF RID: 51423 RVA: 0x00117D34 File Offset: 0x00115F34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600C8E0 RID: 51424
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetPoint_05(HandleRef pThis);

		/// <summary>
		/// Get the current point coordinates during processing. Value only valid during the
		/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
		/// </summary>
		// Token: 0x0600C8E1 RID: 51425 RVA: 0x00117D50 File Offset: 0x00115F50
		public virtual double[] GetPoint()
		{
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPoint_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600C8E2 RID: 51426
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_GetPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Get the current point coordinates during processing. Value only valid during the
		/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
		/// </summary>
		// Token: 0x0600C8E3 RID: 51427 RVA: 0x00117D98 File Offset: 0x00115F98
		public virtual void GetPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPoint_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600C8E4 RID: 51428
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_GetPoint_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the current point coordinates during processing. Value only valid during the
		/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
		/// </summary>
		// Token: 0x0600C8E5 RID: 51429 RVA: 0x00117DAA File Offset: 0x00115FAA
		public virtual void GetPoint(IntPtr _arg)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPoint_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C8E6 RID: 51430
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetPointData_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the set of point data attributes for the input. A convenience to the
		/// programmer to be used in the GlyphMethod(). Only valid during the Execute()
		/// method of this filter.
		/// </summary>
		// Token: 0x0600C8E7 RID: 51431 RVA: 0x00117DBC File Offset: 0x00115FBC
		public virtual vtkPointData GetPointData()
		{
			vtkPointData vtkPointData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPointData_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointData = (vtkPointData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointData.Register(null);
				}
			}
			return vtkPointData;
		}

		// Token: 0x0600C8E8 RID: 51432
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgrammableGlyphFilter_GetPointId_09(HandleRef pThis);

		/// <summary>
		/// Get the current point id during processing. Value only valid during the
		/// Execute() method of this filter. (Meant to be called by the GlyphMethod().)
		/// </summary>
		// Token: 0x0600C8E9 RID: 51433 RVA: 0x00117E2C File Offset: 0x0011602C
		public virtual long GetPointId()
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetPointId_09(base.GetCppThis());
		}

		// Token: 0x0600C8EA RID: 51434
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableGlyphFilter_GetSource_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the source to use for this glyph.
		/// Note that SetSourceData() does not set a pipeline connection but
		/// directly uses the polydata.
		/// </summary>
		// Token: 0x0600C8EB RID: 51435 RVA: 0x00117E4C File Offset: 0x0011604C
		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_GetSource_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600C8EC RID: 51436
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableGlyphFilter_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8ED RID: 51437 RVA: 0x00117EBC File Offset: 0x001160BC
		public override int IsA(string type)
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600C8EE RID: 51438
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgrammableGlyphFilter_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8EF RID: 51439 RVA: 0x00117EDC File Offset: 0x001160DC
		public new static int IsTypeOf(string type)
		{
			return vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_IsTypeOf_12(type);
		}

		// Token: 0x0600C8F0 RID: 51440
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableGlyphFilter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8F1 RID: 51441 RVA: 0x00117EF8 File Offset: 0x001160F8
		public new vtkProgrammableGlyphFilter NewInstance()
		{
			vtkProgrammableGlyphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C8F2 RID: 51442
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgrammableGlyphFilter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C8F3 RID: 51443 RVA: 0x00117F54 File Offset: 0x00116154
		public new static vtkProgrammableGlyphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkProgrammableGlyphFilter vtkProgrammableGlyphFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgrammableGlyphFilter = (vtkProgrammableGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgrammableGlyphFilter.Register(null);
				}
			}
			return vtkProgrammableGlyphFilter;
		}

		// Token: 0x0600C8F4 RID: 51444
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_SetColorMode_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Either color by the input or source scalar data.
		/// </summary>
		// Token: 0x0600C8F5 RID: 51445 RVA: 0x00117FD3 File Offset: 0x001161D3
		public virtual void SetColorMode(int _arg)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetColorMode_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C8F6 RID: 51446
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_SetColorModeToColorByInput_17(HandleRef pThis);

		/// <summary>
		/// Either color by the input or source scalar data.
		/// </summary>
		// Token: 0x0600C8F7 RID: 51447 RVA: 0x00117FE3 File Offset: 0x001161E3
		public void SetColorModeToColorByInput()
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetColorModeToColorByInput_17(base.GetCppThis());
		}

		// Token: 0x0600C8F8 RID: 51448
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_SetColorModeToColorBySource_18(HandleRef pThis);

		/// <summary>
		/// Either color by the input or source scalar data.
		/// </summary>
		// Token: 0x0600C8F9 RID: 51449 RVA: 0x00117FF2 File Offset: 0x001161F2
		public void SetColorModeToColorBySource()
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetColorModeToColorBySource_18(base.GetCppThis());
		}

		// Token: 0x0600C8FA RID: 51450
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_SetGlyphMethod_19(HandleRef pThis, vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f, IntPtr arg);

		/// <summary>
		/// Specify function to be called for each input point.
		/// </summary>
		// Token: 0x0600C8FB RID: 51451 RVA: 0x00118001 File Offset: 0x00116201
		public void SetGlyphMethod(vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f, IntPtr arg)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetGlyphMethod_19(base.GetCppThis(), f, arg);
		}

		// Token: 0x0600C8FC RID: 51452
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_SetGlyphMethodArgDelete_20(HandleRef pThis, vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f);

		/// <summary>
		/// Set the arg delete method. This is used to free user memory that might
		/// be associated with the GlyphMethod().
		/// </summary>
		// Token: 0x0600C8FD RID: 51453 RVA: 0x00118012 File Offset: 0x00116212
		public void SetGlyphMethodArgDelete(vtkProgrammableGlyphFilter.ProgrammableMethodCallbackType f)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetGlyphMethodArgDelete_20(base.GetCppThis(), f);
		}

		// Token: 0x0600C8FE RID: 51454
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_SetSourceConnection_21(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Setup a connection for the source to use as the glyph.
		/// Note: you can change the source during execution of this filter.
		/// This is equivalent to SetInputConnection(1, output);
		/// </summary>
		// Token: 0x0600C8FF RID: 51455 RVA: 0x00118024 File Offset: 0x00116224
		public void SetSourceConnection(vtkAlgorithmOutput output)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetSourceConnection_21(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0600C900 RID: 51456
		[DllImport("Kitware.VTK.FiltersProgrammable.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgrammableGlyphFilter_SetSourceData_22(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Set/Get the source to use for this glyph.
		/// Note that SetSourceData() does not set a pipeline connection but
		/// directly uses the polydata.
		/// </summary>
		// Token: 0x0600C901 RID: 51457 RVA: 0x00118054 File Offset: 0x00116254
		public void SetSourceData(vtkPolyData source)
		{
			vtkProgrammableGlyphFilter.vtkProgrammableGlyphFilter_SetSourceData_22(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EED RID: 3821
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgrammableGlyphFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EEE RID: 3822
		public new static readonly string MRClassNameKey = "class vtkProgrammableGlyphFilter";

		/// <summary>
		/// Signature definition for programmable method callbacks. Methods passed to
		/// SetGlyphMethod or SetGlyphMethodArgDelete must conform to this signature.
		/// The presence of this typedef is useful for reference and for external
		/// analysis tools, but it cannot be used in the method signatures in these
		/// header files themselves because it prevents the internal VTK wrapper
		/// generators from wrapping these methods.
		/// </summary>
		// Token: 0x02000432 RID: 1074
		// (Invoke) Token: 0x0600C903 RID: 51459
		public delegate void ProgrammableMethodCallbackType(IntPtr arg0);
	}
}
