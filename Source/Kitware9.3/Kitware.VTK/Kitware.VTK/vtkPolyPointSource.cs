using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyPointSource
	/// </summary>
	/// <remarks>
	///    create points from a list of input points
	///
	/// vtkPolyPointSource is a source object that creates a vert from
	/// user-specified points. The output is a vtkPolyData.
	/// </remarks>
	// Token: 0x02000839 RID: 2105
	public class vtkPolyPointSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015C94 RID: 89236 RVA: 0x001EBC2B File Offset: 0x001E9E2B
		static vtkPolyPointSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyPointSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyPointSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015C95 RID: 89237 RVA: 0x001EBC53 File Offset: 0x001E9E53
		public vtkPolyPointSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015C96 RID: 89238
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPointSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C97 RID: 89239 RVA: 0x001EBC64 File Offset: 0x001E9E64
		public new static vtkPolyPointSource New()
		{
			vtkPolyPointSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPointSource.vtkPolyPointSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C98 RID: 89240 RVA: 0x001EBCB8 File Offset: 0x001E9EB8
		public vtkPolyPointSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyPointSource.vtkPolyPointSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015C99 RID: 89241 RVA: 0x001EBCFC File Offset: 0x001E9EFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015C9A RID: 89242
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPolyPointSource_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Get the mtime plus consider its Points
		/// </summary>
		// Token: 0x06015C9B RID: 89243 RVA: 0x001EBD08 File Offset: 0x001E9F08
		public override ulong GetMTime()
		{
			return vtkPolyPointSource.vtkPolyPointSource_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x06015C9C RID: 89244
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyPointSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C9D RID: 89245 RVA: 0x001EBD28 File Offset: 0x001E9F28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyPointSource.vtkPolyPointSource_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06015C9E RID: 89246
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyPointSource_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015C9F RID: 89247 RVA: 0x001EBD48 File Offset: 0x001E9F48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyPointSource.vtkPolyPointSource_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06015CA0 RID: 89248
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyPointSource_GetNumberOfPoints_04(HandleRef pThis);

		/// <summary>
		/// Set the number of points in the poly line.
		/// </summary>
		// Token: 0x06015CA1 RID: 89249 RVA: 0x001EBD64 File Offset: 0x001E9F64
		public long GetNumberOfPoints()
		{
			return vtkPolyPointSource.vtkPolyPointSource_GetNumberOfPoints_04(base.GetCppThis());
		}

		// Token: 0x06015CA2 RID: 89250
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPointSource_GetPoints_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the points.
		/// </summary>
		// Token: 0x06015CA3 RID: 89251 RVA: 0x001EBD84 File Offset: 0x001E9F84
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPointSource.vtkPolyPointSource_GetPoints_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x06015CA4 RID: 89252
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyPointSource_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CA5 RID: 89253 RVA: 0x001EBDF4 File Offset: 0x001E9FF4
		public override int IsA(string type)
		{
			return vtkPolyPointSource.vtkPolyPointSource_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06015CA6 RID: 89254
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyPointSource_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CA7 RID: 89255 RVA: 0x001EBE14 File Offset: 0x001EA014
		public new static int IsTypeOf(string type)
		{
			return vtkPolyPointSource.vtkPolyPointSource_IsTypeOf_07(type);
		}

		// Token: 0x06015CA8 RID: 89256
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPointSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CA9 RID: 89257 RVA: 0x001EBE30 File Offset: 0x001EA030
		public new vtkPolyPointSource NewInstance()
		{
			vtkPolyPointSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPointSource.vtkPolyPointSource_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015CAA RID: 89258
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyPointSource_Resize_10(HandleRef pThis, long numPoints);

		/// <summary>
		/// Resize while preserving data.
		/// </summary>
		// Token: 0x06015CAB RID: 89259 RVA: 0x001EBE8A File Offset: 0x001EA08A
		public void Resize(long numPoints)
		{
			vtkPolyPointSource.vtkPolyPointSource_Resize_10(base.GetCppThis(), numPoints);
		}

		// Token: 0x06015CAC RID: 89260
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyPointSource_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015CAD RID: 89261 RVA: 0x001EBE9C File Offset: 0x001EA09C
		public new static vtkPolyPointSource SafeDownCast(vtkObjectBase o)
		{
			vtkPolyPointSource vtkPolyPointSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyPointSource.vtkPolyPointSource_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyPointSource = (vtkPolyPointSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyPointSource.Register(null);
				}
			}
			return vtkPolyPointSource;
		}

		// Token: 0x06015CAE RID: 89262
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyPointSource_SetNumberOfPoints_12(HandleRef pThis, long numPoints);

		/// <summary>
		/// Set the number of points in the poly line.
		/// </summary>
		// Token: 0x06015CAF RID: 89263 RVA: 0x001EBF1B File Offset: 0x001EA11B
		public void SetNumberOfPoints(long numPoints)
		{
			vtkPolyPointSource.vtkPolyPointSource_SetNumberOfPoints_12(base.GetCppThis(), numPoints);
		}

		// Token: 0x06015CB0 RID: 89264
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyPointSource_SetPoint_13(HandleRef pThis, long id, double x, double y, double z);

		/// <summary>
		/// Set a point location.
		/// </summary>
		// Token: 0x06015CB1 RID: 89265 RVA: 0x001EBF2B File Offset: 0x001EA12B
		public void SetPoint(long id, double x, double y, double z)
		{
			vtkPolyPointSource.vtkPolyPointSource_SetPoint_13(base.GetCppThis(), id, x, y, z);
		}

		// Token: 0x06015CB2 RID: 89266
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyPointSource_SetPoints_14(HandleRef pThis, HandleRef points);

		/// <summary>
		/// Get the points.
		/// </summary>
		// Token: 0x06015CB3 RID: 89267 RVA: 0x001EBF40 File Offset: 0x001EA140
		public void SetPoints(vtkPoints points)
		{
			vtkPolyPointSource.vtkPolyPointSource_SetPoints_14(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C9 RID: 6345
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyPointSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018CA RID: 6346
		public new static readonly string MRClassNameKey = "class vtkPolyPointSource";
	}
}
