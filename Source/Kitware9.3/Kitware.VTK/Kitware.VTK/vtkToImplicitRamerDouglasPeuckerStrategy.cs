using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkToImplicitRamerDouglasPeuckerStrategy
	///
	/// A strategy for creating constant or affine by parts implicit arrays from explicit memory arrays
	/// based on the Ramer-Douglas-Peucker algorithm(*).
	///
	/// (*)References:
	/// - https://en.wikipedia.org/wiki/Ramer%E2%80%93Douglas%E2%80%93Peucker_algorithm
	/// - https://cartography-playground.gitlab.io/playgrounds/douglas-peucker-algorithm/
	/// - Urs Ramer, An iterative procedure for the polygonal approximation of plane curves, Computer
	/// Graphics and Image Processing, Volume 1, Issue 3, 1972, Pages 244-256, ISSN 0146-664X,
	/// https://doi.org/10.1016/S0146-664X(72)80017-0.
	/// (https://www.sciencedirect.com/science/article/pii/S0146664X72800170)
	/// - DOUGLAS, DAVID &amp; PEUCKER, THOMAS. (1973). Algorithms for the Reduction of the Number of Points
	/// Required to Represent a Digitized Line or Its Caricature. Cartographica: The International
	/// Journal for Geographic Information and Geovisualization. 10.
	/// 112-122. 10.3138/FM57-6770-U75U-7727.
	///
	/// </summary>
	// Token: 0x0200042A RID: 1066
	public class vtkToImplicitRamerDouglasPeuckerStrategy : vtkToImplicitStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C853 RID: 51283 RVA: 0x00116DF9 File Offset: 0x00114FF9
		static vtkToImplicitRamerDouglasPeuckerStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkToImplicitRamerDouglasPeuckerStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkToImplicitRamerDouglasPeuckerStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C854 RID: 51284 RVA: 0x00116E21 File Offset: 0x00115021
		public vtkToImplicitRamerDouglasPeuckerStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C855 RID: 51285
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitRamerDouglasPeuckerStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C856 RID: 51286 RVA: 0x00116E30 File Offset: 0x00115030
		public new static vtkToImplicitRamerDouglasPeuckerStrategy New()
		{
			vtkToImplicitRamerDouglasPeuckerStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToImplicitRamerDouglasPeuckerStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C857 RID: 51287 RVA: 0x00116E84 File Offset: 0x00115084
		public vtkToImplicitRamerDouglasPeuckerStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C858 RID: 51288 RVA: 0x00116EC8 File Offset: 0x001150C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C859 RID: 51289
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitRamerDouglasPeuckerStrategy_ClearCache_01(HandleRef pThis);

		/// <summary>
		/// Destroys intermediate result of Ramer-Douglas-Peucker algorithm on last array passed to
		/// `EstimateReduction`
		/// </summary>
		// Token: 0x0600C85A RID: 51290 RVA: 0x00116ED3 File Offset: 0x001150D3
		public override void ClearCache()
		{
			vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_ClearCache_01(base.GetCppThis());
		}

		// Token: 0x0600C85B RID: 51291
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitRamerDouglasPeuckerStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C85C RID: 51292 RVA: 0x00116EE4 File Offset: 0x001150E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C85D RID: 51293
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitRamerDouglasPeuckerStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C85E RID: 51294 RVA: 0x00116F04 File Offset: 0x00115104
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C85F RID: 51295
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitRamerDouglasPeuckerStrategy_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C860 RID: 51296 RVA: 0x00116F20 File Offset: 0x00115120
		public override int IsA(string type)
		{
			return vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C861 RID: 51297
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitRamerDouglasPeuckerStrategy_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C862 RID: 51298 RVA: 0x00116F40 File Offset: 0x00115140
		public new static int IsTypeOf(string type)
		{
			return vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_IsTypeOf_05(type);
		}

		// Token: 0x0600C863 RID: 51299
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitRamerDouglasPeuckerStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C864 RID: 51300 RVA: 0x00116F5C File Offset: 0x0011515C
		public new vtkToImplicitRamerDouglasPeuckerStrategy NewInstance()
		{
			vtkToImplicitRamerDouglasPeuckerStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToImplicitRamerDouglasPeuckerStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C865 RID: 51301
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitRamerDouglasPeuckerStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C866 RID: 51302 RVA: 0x00116FB8 File Offset: 0x001151B8
		public new static vtkToImplicitRamerDouglasPeuckerStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkToImplicitRamerDouglasPeuckerStrategy vtkToImplicitRamerDouglasPeuckerStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitRamerDouglasPeuckerStrategy.vtkToImplicitRamerDouglasPeuckerStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToImplicitRamerDouglasPeuckerStrategy = (vtkToImplicitRamerDouglasPeuckerStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToImplicitRamerDouglasPeuckerStrategy.Register(null);
				}
			}
			return vtkToImplicitRamerDouglasPeuckerStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE5 RID: 3813
		public new const string MRFullTypeName = "Kitware.VTK.vtkToImplicitRamerDouglasPeuckerStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EE6 RID: 3814
		public new static readonly string MRClassNameKey = "class vtkToImplicitRamerDouglasPeuckerStrategy";
	}
}
