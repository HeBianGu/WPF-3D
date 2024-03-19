using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeoEdgeStrategy
	/// </summary>
	/// <remarks>
	///    Layout graph edges on a globe as arcs.
	///
	///
	/// vtkGeoEdgeStrategy produces arcs for each edge in the input graph.
	/// This is useful for viewing lines on a sphere (e.g. the earth).
	/// The arcs may "jump" above the sphere's surface using ExplodeFactor.
	/// </remarks>
	// Token: 0x0200028F RID: 655
	public class vtkGeoEdgeStrategy : vtkEdgeLayoutStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060076B6 RID: 30390 RVA: 0x000AB389 File Offset: 0x000A9589
		static vtkGeoEdgeStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoEdgeStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoEdgeStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060076B7 RID: 30391 RVA: 0x000AB3B1 File Offset: 0x000A95B1
		public vtkGeoEdgeStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060076B8 RID: 30392
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoEdgeStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076B9 RID: 30393 RVA: 0x000AB3C0 File Offset: 0x000A95C0
		public new static vtkGeoEdgeStrategy New()
		{
			vtkGeoEdgeStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076BA RID: 30394 RVA: 0x000AB414 File Offset: 0x000A9614
		public vtkGeoEdgeStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060076BB RID: 30395 RVA: 0x000AB458 File Offset: 0x000A9658
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060076BC RID: 30396
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeoEdgeStrategy_GetExplodeFactor_01(HandleRef pThis);

		/// <summary>
		/// Factor on which to "explode" the arcs away from the surface.
		/// A value of 0.0 keeps the values on the surface.
		/// Values larger than 0.0 push the arcs away from the surface by a distance
		/// proportional to the distance between the points.
		/// The default is 0.2.
		/// </summary>
		// Token: 0x060076BD RID: 30397 RVA: 0x000AB464 File Offset: 0x000A9664
		public virtual double GetExplodeFactor()
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetExplodeFactor_01(base.GetCppThis());
		}

		// Token: 0x060076BE RID: 30398
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkGeoEdgeStrategy_GetGlobeRadius_02(HandleRef pThis);

		/// <summary>
		/// The base radius used to determine the earth's surface.
		/// Default is the earth's radius in meters.
		/// TODO: Change this to take in a vtkGeoTerrain to get altitude.
		/// </summary>
		// Token: 0x060076BF RID: 30399 RVA: 0x000AB484 File Offset: 0x000A9684
		public virtual double GetGlobeRadius()
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetGlobeRadius_02(base.GetCppThis());
		}

		// Token: 0x060076C0 RID: 30400
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076C1 RID: 30401 RVA: 0x000AB4A4 File Offset: 0x000A96A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060076C2 RID: 30402
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076C3 RID: 30403 RVA: 0x000AB4C4 File Offset: 0x000A96C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060076C4 RID: 30404
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoEdgeStrategy_GetNumberOfSubdivisions_05(HandleRef pThis);

		/// <summary>
		/// The number of subdivisions in the arc.
		/// The default is 20.
		/// </summary>
		// Token: 0x060076C5 RID: 30405 RVA: 0x000AB4E0 File Offset: 0x000A96E0
		public virtual int GetNumberOfSubdivisions()
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetNumberOfSubdivisions_05(base.GetCppThis());
		}

		// Token: 0x060076C6 RID: 30406
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoEdgeStrategy_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076C7 RID: 30407 RVA: 0x000AB500 File Offset: 0x000A9700
		public override int IsA(string type)
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060076C8 RID: 30408
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeoEdgeStrategy_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076C9 RID: 30409 RVA: 0x000AB520 File Offset: 0x000A9720
		public new static int IsTypeOf(string type)
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_IsTypeOf_07(type);
		}

		// Token: 0x060076CA RID: 30410
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoEdgeStrategy_Layout_08(HandleRef pThis);

		/// <summary>
		/// Perform the layout.
		/// </summary>
		// Token: 0x060076CB RID: 30411 RVA: 0x000AB53A File Offset: 0x000A973A
		public override void Layout()
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_Layout_08(base.GetCppThis());
		}

		// Token: 0x060076CC RID: 30412
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoEdgeStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076CD RID: 30413 RVA: 0x000AB54C File Offset: 0x000A974C
		public new vtkGeoEdgeStrategy NewInstance()
		{
			vtkGeoEdgeStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060076CE RID: 30414
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeoEdgeStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060076CF RID: 30415 RVA: 0x000AB5A8 File Offset: 0x000A97A8
		public new static vtkGeoEdgeStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkGeoEdgeStrategy vtkGeoEdgeStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoEdgeStrategy = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoEdgeStrategy.Register(null);
				}
			}
			return vtkGeoEdgeStrategy;
		}

		// Token: 0x060076D0 RID: 30416
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoEdgeStrategy_SetExplodeFactor_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Factor on which to "explode" the arcs away from the surface.
		/// A value of 0.0 keeps the values on the surface.
		/// Values larger than 0.0 push the arcs away from the surface by a distance
		/// proportional to the distance between the points.
		/// The default is 0.2.
		/// </summary>
		// Token: 0x060076D1 RID: 30417 RVA: 0x000AB627 File Offset: 0x000A9827
		public virtual void SetExplodeFactor(double _arg)
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SetExplodeFactor_12(base.GetCppThis(), _arg);
		}

		// Token: 0x060076D2 RID: 30418
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoEdgeStrategy_SetGlobeRadius_13(HandleRef pThis, double _arg);

		/// <summary>
		/// The base radius used to determine the earth's surface.
		/// Default is the earth's radius in meters.
		/// TODO: Change this to take in a vtkGeoTerrain to get altitude.
		/// </summary>
		// Token: 0x060076D3 RID: 30419 RVA: 0x000AB637 File Offset: 0x000A9837
		public virtual void SetGlobeRadius(double _arg)
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SetGlobeRadius_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060076D4 RID: 30420
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGeoEdgeStrategy_SetNumberOfSubdivisions_14(HandleRef pThis, int _arg);

		/// <summary>
		/// The number of subdivisions in the arc.
		/// The default is 20.
		/// </summary>
		// Token: 0x060076D5 RID: 30421 RVA: 0x000AB647 File Offset: 0x000A9847
		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SetNumberOfSubdivisions_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A2C RID: 2604
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoEdgeStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A2D RID: 2605
		public new static readonly string MRClassNameKey = "class vtkGeoEdgeStrategy";
	}
}
