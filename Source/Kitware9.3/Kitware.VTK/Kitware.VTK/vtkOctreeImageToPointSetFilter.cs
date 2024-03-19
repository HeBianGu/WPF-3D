using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOctreeImageToPointSetFilter
	/// </summary>
	/// <remarks>
	///    Convert an octree image to point set
	///
	/// vtkOctreeImageToPointSetFilter is a filter that converts an image with an octree unsigned char
	/// cell array to a pointset. Each bit of the unsigned char indicates if the cell had a point close
	/// to one of its 8 corners.
	///
	/// It can optionally also output a point data array based on an input cell data scalar array by
	/// setting SetInputArrayToProcess. This array will have one of the components of the input array.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///  vtkPointSetToOctreeImageFilter
	/// </seealso>
	// Token: 0x02000494 RID: 1172
	public class vtkOctreeImageToPointSetFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D78D RID: 55181 RVA: 0x0012BB41 File Offset: 0x00129D41
		static vtkOctreeImageToPointSetFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOctreeImageToPointSetFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreeImageToPointSetFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D78E RID: 55182 RVA: 0x0012BB69 File Offset: 0x00129D69
		public vtkOctreeImageToPointSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D78F RID: 55183
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreeImageToPointSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D790 RID: 55184 RVA: 0x0012BB78 File Offset: 0x00129D78
		public new static vtkOctreeImageToPointSetFilter New()
		{
			vtkOctreeImageToPointSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreeImageToPointSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D791 RID: 55185 RVA: 0x0012BBCC File Offset: 0x00129DCC
		public vtkOctreeImageToPointSetFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D792 RID: 55186 RVA: 0x0012BC10 File Offset: 0x00129E10
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D793 RID: 55187
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D794 RID: 55188 RVA: 0x0012BC1B File Offset: 0x00129E1B
		public virtual void CreateVerticesCellArrayOff()
		{
			vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOff_01(base.GetCppThis());
		}

		// Token: 0x0600D795 RID: 55189
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D796 RID: 55190 RVA: 0x0012BC2A File Offset: 0x00129E2A
		public virtual void CreateVerticesCellArrayOn()
		{
			vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_CreateVerticesCellArrayOn_02(base.GetCppThis());
		}

		// Token: 0x0600D797 RID: 55191
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreeImageToPointSetFilter_GetCellArrayComponent_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the component of the input cell data array to process.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D798 RID: 55192 RVA: 0x0012BC3C File Offset: 0x00129E3C
		public virtual int GetCellArrayComponent()
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_GetCellArrayComponent_03(base.GetCppThis());
		}

		// Token: 0x0600D799 RID: 55193
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreeImageToPointSetFilter_GetCellArrayComponentMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the component of the input cell data array to process.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D79A RID: 55194 RVA: 0x0012BC5C File Offset: 0x00129E5C
		public virtual int GetCellArrayComponentMaxValue()
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_GetCellArrayComponentMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600D79B RID: 55195
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreeImageToPointSetFilter_GetCellArrayComponentMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the component of the input cell data array to process.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D79C RID: 55196 RVA: 0x0012BC7C File Offset: 0x00129E7C
		public virtual int GetCellArrayComponentMinValue()
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_GetCellArrayComponentMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600D79D RID: 55197
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOctreeImageToPointSetFilter_GetCreateVerticesCellArray_06(HandleRef pThis);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D79E RID: 55198 RVA: 0x0012BC9C File Offset: 0x00129E9C
		public virtual bool GetCreateVerticesCellArray()
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_GetCreateVerticesCellArray_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D79F RID: 55199
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7A0 RID: 55200 RVA: 0x0012BCC4 File Offset: 0x00129EC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600D7A1 RID: 55201
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7A2 RID: 55202 RVA: 0x0012BCE4 File Offset: 0x00129EE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600D7A3 RID: 55203
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOctreeImageToPointSetFilter_GetProcessInputCellArray_09(HandleRef pThis);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D7A4 RID: 55204 RVA: 0x0012BD00 File Offset: 0x00129F00
		public virtual bool GetProcessInputCellArray()
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_GetProcessInputCellArray_09(base.GetCppThis()) != 0;
		}

		// Token: 0x0600D7A5 RID: 55205
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreeImageToPointSetFilter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7A6 RID: 55206 RVA: 0x0012BD28 File Offset: 0x00129F28
		public override int IsA(string type)
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600D7A7 RID: 55207
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOctreeImageToPointSetFilter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7A8 RID: 55208 RVA: 0x0012BD48 File Offset: 0x00129F48
		public new static int IsTypeOf(string type)
		{
			return vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_IsTypeOf_11(type);
		}

		// Token: 0x0600D7A9 RID: 55209
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreeImageToPointSetFilter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7AA RID: 55210 RVA: 0x0012BD64 File Offset: 0x00129F64
		public new vtkOctreeImageToPointSetFilter NewInstance()
		{
			vtkOctreeImageToPointSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreeImageToPointSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D7AB RID: 55211
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOff_14(HandleRef pThis);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D7AC RID: 55212 RVA: 0x0012BDBE File Offset: 0x00129FBE
		public virtual void ProcessInputCellArrayOff()
		{
			vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOff_14(base.GetCppThis());
		}

		// Token: 0x0600D7AD RID: 55213
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOn_15(HandleRef pThis);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D7AE RID: 55214 RVA: 0x0012BDCD File Offset: 0x00129FCD
		public virtual void ProcessInputCellArrayOn()
		{
			vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_ProcessInputCellArrayOn_15(base.GetCppThis());
		}

		// Token: 0x0600D7AF RID: 55215
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOctreeImageToPointSetFilter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D7B0 RID: 55216 RVA: 0x0012BDDC File Offset: 0x00129FDC
		public new static vtkOctreeImageToPointSetFilter SafeDownCast(vtkObjectBase o)
		{
			vtkOctreeImageToPointSetFilter vtkOctreeImageToPointSetFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOctreeImageToPointSetFilter = (vtkOctreeImageToPointSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOctreeImageToPointSetFilter.Register(null);
				}
			}
			return vtkOctreeImageToPointSetFilter;
		}

		// Token: 0x0600D7B1 RID: 55217
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreeImageToPointSetFilter_SetCellArrayComponent_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the component of the input cell data array to process.
		///
		/// The default is 0.
		/// </summary>
		// Token: 0x0600D7B2 RID: 55218 RVA: 0x0012BE5B File Offset: 0x0012A05B
		public virtual void SetCellArrayComponent(int _arg)
		{
			vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_SetCellArrayComponent_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D7B3 RID: 55219
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreeImageToPointSetFilter_SetCreateVerticesCellArray_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if a cell array of vertices will be created.
		///
		/// The default is on.
		/// </summary>
		// Token: 0x0600D7B4 RID: 55220 RVA: 0x0012BE6B File Offset: 0x0012A06B
		public virtual void SetCreateVerticesCellArray(bool _arg)
		{
			vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_SetCreateVerticesCellArray_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600D7B5 RID: 55221
		[DllImport("Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOctreeImageToPointSetFilter_SetProcessInputCellArray_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get if array defined using SetInputArrayToProcess, which MUST be a cell data array, will
		/// be processed.
		///
		/// The default is off.
		/// </summary>
		// Token: 0x0600D7B6 RID: 55222 RVA: 0x0012BE83 File Offset: 0x0012A083
		public virtual void SetProcessInputCellArray(bool _arg)
		{
			vtkOctreeImageToPointSetFilter.vtkOctreeImageToPointSetFilter_SetProcessInputCellArray_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD0 RID: 4048
		public new const string MRFullTypeName = "Kitware.VTK.vtkOctreeImageToPointSetFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FD1 RID: 4049
		public new static readonly string MRClassNameKey = "class vtkOctreeImageToPointSetFilter";
	}
}
