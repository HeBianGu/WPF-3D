using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkToImplicitStrategy
	///
	/// Pure interface for strategies to transform explicit arrays into implicit arrays. The interface
	/// has two main components: an `EstimateReduction` method which estimates by how much this strategy
	/// can reduce the memory usage of the array and a `Reduce` method which returns a reduced array.
	/// </summary>
	// Token: 0x02000426 RID: 1062
	public abstract class vtkToImplicitStrategy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C7E4 RID: 51172 RVA: 0x001160B8 File Offset: 0x001142B8
		static vtkToImplicitStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkToImplicitStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkToImplicitStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7E5 RID: 51173 RVA: 0x001160E0 File Offset: 0x001142E0
		public vtkToImplicitStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C7E6 RID: 51174 RVA: 0x001160EE File Offset: 0x001142EE
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C7E7 RID: 51175
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitStrategy_ClearCache_01(HandleRef pThis);

		/// <summary>
		/// Destroy any cached variables present in the object (useful for storing calculation results
		/// in-between the estimation and reduction phases).
		///
		/// The default implementation does nothing.
		/// </summary>
		// Token: 0x0600C7E8 RID: 51176 RVA: 0x001160F9 File Offset: 0x001142F9
		public virtual void ClearCache()
		{
			vtkToImplicitStrategy.vtkToImplicitStrategy_ClearCache_01(base.GetCppThis());
		}

		// Token: 0x0600C7E9 RID: 51177
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7EA RID: 51178 RVA: 0x00116108 File Offset: 0x00114308
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkToImplicitStrategy.vtkToImplicitStrategy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C7EB RID: 51179
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkToImplicitStrategy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7EC RID: 51180 RVA: 0x00116128 File Offset: 0x00114328
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkToImplicitStrategy.vtkToImplicitStrategy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C7ED RID: 51181
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkToImplicitStrategy_GetTolerance_04(HandleRef pThis);

		/// <summary>
		/// Getter/Setter for tolerance parameter
		///
		/// This tolerance controls how close a compressed value needs to be to the actual value to be
		/// considered a match in absolute terms.
		///
		/// Default value: 0.001
		/// </summary>
		// Token: 0x0600C7EE RID: 51182 RVA: 0x00116144 File Offset: 0x00114344
		public virtual double GetTolerance()
		{
			return vtkToImplicitStrategy.vtkToImplicitStrategy_GetTolerance_04(base.GetCppThis());
		}

		// Token: 0x0600C7EF RID: 51183
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitStrategy_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7F0 RID: 51184 RVA: 0x00116164 File Offset: 0x00114364
		public override int IsA(string type)
		{
			return vtkToImplicitStrategy.vtkToImplicitStrategy_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C7F1 RID: 51185
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkToImplicitStrategy_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7F2 RID: 51186 RVA: 0x00116184 File Offset: 0x00114384
		public new static int IsTypeOf(string type)
		{
			return vtkToImplicitStrategy.vtkToImplicitStrategy_IsTypeOf_06(type);
		}

		// Token: 0x0600C7F3 RID: 51187
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitStrategy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7F4 RID: 51188 RVA: 0x001161A0 File Offset: 0x001143A0
		public new vtkToImplicitStrategy NewInstance()
		{
			vtkToImplicitStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitStrategy.vtkToImplicitStrategy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkToImplicitStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C7F5 RID: 51189
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkToImplicitStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C7F6 RID: 51190 RVA: 0x001161FC File Offset: 0x001143FC
		public new static vtkToImplicitStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkToImplicitStrategy vtkToImplicitStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkToImplicitStrategy.vtkToImplicitStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkToImplicitStrategy = (vtkToImplicitStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkToImplicitStrategy.Register(null);
				}
			}
			return vtkToImplicitStrategy;
		}

		// Token: 0x0600C7F7 RID: 51191
		[DllImport("Kitware.VTK.FiltersReduction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkToImplicitStrategy_SetTolerance_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Getter/Setter for tolerance parameter
		///
		/// This tolerance controls how close a compressed value needs to be to the actual value to be
		/// considered a match in absolute terms.
		///
		/// Default value: 0.001
		/// </summary>
		// Token: 0x0600C7F8 RID: 51192 RVA: 0x0011627B File Offset: 0x0011447B
		public virtual void SetTolerance(double _arg)
		{
			vtkToImplicitStrategy.vtkToImplicitStrategy_SetTolerance_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EDD RID: 3805
		public new const string MRFullTypeName = "Kitware.VTK.vtkToImplicitStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EDE RID: 3806
		public new static readonly string MRClassNameKey = "class vtkToImplicitStrategy";
	}
}
