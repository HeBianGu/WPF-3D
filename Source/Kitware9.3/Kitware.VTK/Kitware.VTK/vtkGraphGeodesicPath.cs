using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphGeodesicPath
	/// </summary>
	/// <remarks>
	///    Abstract base for classes that generate a geodesic path on a graph (mesh).
	///
	/// Serves as a base class for algorithms that trace a geodesic on a
	/// polygonal dataset treating it as a graph. ie points connecting the
	/// vertices of the graph
	/// </remarks>
	// Token: 0x02000551 RID: 1361
	public class vtkGraphGeodesicPath : vtkGeodesicPath
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F220 RID: 61984 RVA: 0x001514D7 File Offset: 0x0014F6D7
		static vtkGraphGeodesicPath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphGeodesicPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphGeodesicPath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F221 RID: 61985 RVA: 0x001514FF File Offset: 0x0014F6FF
		public vtkGraphGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F222 RID: 61986 RVA: 0x0015150D File Offset: 0x0014F70D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F223 RID: 61987
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphGeodesicPath_GetEndVertex_01(HandleRef pThis);

		/// <summary>
		/// The vertex at the end of the shortest path
		/// </summary>
		// Token: 0x0600F224 RID: 61988 RVA: 0x00151518 File Offset: 0x0014F718
		public virtual long GetEndVertex()
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_GetEndVertex_01(base.GetCppThis());
		}

		// Token: 0x0600F225 RID: 61989
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphGeodesicPath_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F226 RID: 61990 RVA: 0x00151538 File Offset: 0x0014F738
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600F227 RID: 61991
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F228 RID: 61992 RVA: 0x00151558 File Offset: 0x0014F758
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600F229 RID: 61993
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphGeodesicPath_GetStartVertex_04(HandleRef pThis);

		/// <summary>
		/// The vertex at the start of the shortest path
		/// </summary>
		// Token: 0x0600F22A RID: 61994 RVA: 0x00151574 File Offset: 0x0014F774
		public virtual long GetStartVertex()
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_GetStartVertex_04(base.GetCppThis());
		}

		// Token: 0x0600F22B RID: 61995
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphGeodesicPath_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F22C RID: 61996 RVA: 0x00151594 File Offset: 0x0014F794
		public override int IsA(string type)
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600F22D RID: 61997
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphGeodesicPath_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F22E RID: 61998 RVA: 0x001515B4 File Offset: 0x0014F7B4
		public new static int IsTypeOf(string type)
		{
			return vtkGraphGeodesicPath.vtkGraphGeodesicPath_IsTypeOf_06(type);
		}

		// Token: 0x0600F22F RID: 61999
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphGeodesicPath_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F230 RID: 62000 RVA: 0x001515D0 File Offset: 0x0014F7D0
		public new vtkGraphGeodesicPath NewInstance()
		{
			vtkGraphGeodesicPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphGeodesicPath.vtkGraphGeodesicPath_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F231 RID: 62001
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphGeodesicPath_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F232 RID: 62002 RVA: 0x0015162C File Offset: 0x0014F82C
		public new static vtkGraphGeodesicPath SafeDownCast(vtkObjectBase o)
		{
			vtkGraphGeodesicPath vtkGraphGeodesicPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphGeodesicPath.vtkGraphGeodesicPath_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphGeodesicPath = (vtkGraphGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphGeodesicPath.Register(null);
				}
			}
			return vtkGraphGeodesicPath;
		}

		// Token: 0x0600F233 RID: 62003
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphGeodesicPath_SetEndVertex_09(HandleRef pThis, long _arg);

		/// <summary>
		/// The vertex at the end of the shortest path
		/// </summary>
		// Token: 0x0600F234 RID: 62004 RVA: 0x001516AB File Offset: 0x0014F8AB
		public virtual void SetEndVertex(long _arg)
		{
			vtkGraphGeodesicPath.vtkGraphGeodesicPath_SetEndVertex_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F235 RID: 62005
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphGeodesicPath_SetStartVertex_10(HandleRef pThis, long _arg);

		/// <summary>
		/// The vertex at the start of the shortest path
		/// </summary>
		// Token: 0x0600F236 RID: 62006 RVA: 0x001516BB File Offset: 0x0014F8BB
		public virtual void SetStartVertex(long _arg)
		{
			vtkGraphGeodesicPath.vtkGraphGeodesicPath_SetStartVertex_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400119D RID: 4509
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphGeodesicPath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400119E RID: 4510
		public new static readonly string MRClassNameKey = "class vtkGraphGeodesicPath";
	}
}
