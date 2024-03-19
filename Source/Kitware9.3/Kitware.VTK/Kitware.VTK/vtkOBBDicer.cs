using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOBBDicer
	/// </summary>
	/// <remarks>
	///    divide dataset into spatially aggregated pieces
	///
	/// vtkOBBDicer separates the cells of a dataset into spatially
	/// aggregated pieces using a Oriented Bounding Box (OBB). These pieces
	/// can then be operated on by other filters (e.g., vtkThreshold). One
	/// application is to break very large polygonal models into pieces and
	/// performing viewing and occlusion culling on the pieces.
	///
	/// Refer to the superclass documentation (vtkDicer) for more information.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDicer vtkConnectedDicer
	/// </seealso>
	// Token: 0x020008C5 RID: 2245
	public class vtkOBBDicer : vtkDicer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017368 RID: 95080 RVA: 0x00209633 File Offset: 0x00207833
		static vtkOBBDicer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBBDicer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBBDicer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017369 RID: 95081 RVA: 0x0020965B File Offset: 0x0020785B
		public vtkOBBDicer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601736A RID: 95082
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBBDicer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate an object.
		/// </summary>
		// Token: 0x0601736B RID: 95083 RVA: 0x0020966C File Offset: 0x0020786C
		public new static vtkOBBDicer New()
		{
			vtkOBBDicer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBBDicer.vtkOBBDicer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBDicer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate an object.
		/// </summary>
		// Token: 0x0601736C RID: 95084 RVA: 0x002096C0 File Offset: 0x002078C0
		public vtkOBBDicer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOBBDicer.vtkOBBDicer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601736D RID: 95085 RVA: 0x00209704 File Offset: 0x00207904
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601736E RID: 95086
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBBDicer_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601736F RID: 95087 RVA: 0x00209710 File Offset: 0x00207910
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOBBDicer.vtkOBBDicer_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017370 RID: 95088
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOBBDicer_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017371 RID: 95089 RVA: 0x00209730 File Offset: 0x00207930
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOBBDicer.vtkOBBDicer_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017372 RID: 95090
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBBDicer_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017373 RID: 95091 RVA: 0x0020974C File Offset: 0x0020794C
		public override int IsA(string type)
		{
			return vtkOBBDicer.vtkOBBDicer_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06017374 RID: 95092
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOBBDicer_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017375 RID: 95093 RVA: 0x0020976C File Offset: 0x0020796C
		public new static int IsTypeOf(string type)
		{
			return vtkOBBDicer.vtkOBBDicer_IsTypeOf_04(type);
		}

		// Token: 0x06017376 RID: 95094
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBBDicer_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017377 RID: 95095 RVA: 0x00209788 File Offset: 0x00207988
		public new vtkOBBDicer NewInstance()
		{
			vtkOBBDicer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBBDicer.vtkOBBDicer_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBDicer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017378 RID: 95096
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOBBDicer_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017379 RID: 95097 RVA: 0x002097E4 File Offset: 0x002079E4
		public new static vtkOBBDicer SafeDownCast(vtkObjectBase o)
		{
			vtkOBBDicer vtkOBBDicer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOBBDicer.vtkOBBDicer_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBBDicer = (vtkOBBDicer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBBDicer.Register(null);
				}
			}
			return vtkOBBDicer;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019FD RID: 6653
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBBDicer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019FE RID: 6654
		public new static readonly string MRClassNameKey = "class vtkOBBDicer";
	}
}
