using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArcParallelEdgeStrategy
	/// </summary>
	/// <remarks>
	///    routes parallel edges as arcs
	///
	///
	/// Parallel edges are drawn as arcs, and self-loops are drawn as ovals.
	/// When only one edge connects two vertices it is drawn as a straight line.
	/// </remarks>
	// Token: 0x02000279 RID: 633
	public class vtkArcParallelEdgeStrategy : vtkEdgeLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600732A RID: 29482 RVA: 0x000A670B File Offset: 0x000A490B
		static vtkArcParallelEdgeStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArcParallelEdgeStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArcParallelEdgeStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600732B RID: 29483 RVA: 0x000A6733 File Offset: 0x000A4933
		public vtkArcParallelEdgeStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600732C RID: 29484
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcParallelEdgeStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600732D RID: 29485 RVA: 0x000A6744 File Offset: 0x000A4944
		public new static vtkArcParallelEdgeStrategy New()
		{
			vtkArcParallelEdgeStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcParallelEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600732E RID: 29486 RVA: 0x000A6798 File Offset: 0x000A4998
		public vtkArcParallelEdgeStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600732F RID: 29487 RVA: 0x000A67DC File Offset: 0x000A49DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007330 RID: 29488
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArcParallelEdgeStrategy_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007331 RID: 29489 RVA: 0x000A67E8 File Offset: 0x000A49E8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06007332 RID: 29490
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArcParallelEdgeStrategy_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007333 RID: 29491 RVA: 0x000A6808 File Offset: 0x000A4A08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06007334 RID: 29492
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcParallelEdgeStrategy_GetNumberOfSubdivisions_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of subdivisions on each edge.
		/// </summary>
		// Token: 0x06007335 RID: 29493 RVA: 0x000A6824 File Offset: 0x000A4A24
		public virtual int GetNumberOfSubdivisions()
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_GetNumberOfSubdivisions_03(base.GetCppThis());
		}

		// Token: 0x06007336 RID: 29494
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcParallelEdgeStrategy_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007337 RID: 29495 RVA: 0x000A6844 File Offset: 0x000A4A44
		public override int IsA(string type)
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06007338 RID: 29496
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArcParallelEdgeStrategy_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007339 RID: 29497 RVA: 0x000A6864 File Offset: 0x000A4A64
		public new static int IsTypeOf(string type)
		{
			return vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_IsTypeOf_05(type);
		}

		// Token: 0x0600733A RID: 29498
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcParallelEdgeStrategy_Layout_06(HandleRef pThis);

		/// <summary>
		/// This is the layout method where the graph that was
		/// set in SetGraph() is laid out.
		/// </summary>
		// Token: 0x0600733B RID: 29499 RVA: 0x000A687E File Offset: 0x000A4A7E
		public override void Layout()
		{
			vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_Layout_06(base.GetCppThis());
		}

		// Token: 0x0600733C RID: 29500
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcParallelEdgeStrategy_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600733D RID: 29501 RVA: 0x000A6890 File Offset: 0x000A4A90
		public new vtkArcParallelEdgeStrategy NewInstance()
		{
			vtkArcParallelEdgeStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArcParallelEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600733E RID: 29502
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArcParallelEdgeStrategy_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600733F RID: 29503 RVA: 0x000A68EC File Offset: 0x000A4AEC
		public new static vtkArcParallelEdgeStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkArcParallelEdgeStrategy vtkArcParallelEdgeStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArcParallelEdgeStrategy = (vtkArcParallelEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArcParallelEdgeStrategy.Register(null);
				}
			}
			return vtkArcParallelEdgeStrategy;
		}

		// Token: 0x06007340 RID: 29504
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArcParallelEdgeStrategy_SetNumberOfSubdivisions_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of subdivisions on each edge.
		/// </summary>
		// Token: 0x06007341 RID: 29505 RVA: 0x000A696B File Offset: 0x000A4B6B
		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkArcParallelEdgeStrategy.vtkArcParallelEdgeStrategy_SetNumberOfSubdivisions_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A00 RID: 2560
		public new const string MRFullTypeName = "Kitware.VTK.vtkArcParallelEdgeStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A01 RID: 2561
		public new static readonly string MRClassNameKey = "class vtkArcParallelEdgeStrategy";
	}
}
