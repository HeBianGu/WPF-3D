using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkThreadedCompositeDataPipeline
	/// </summary>
	/// <remarks>
	///    Executive that works in parallel
	///
	/// vtkThreadedCompositeDataPipeline processes a composite data object in
	/// parallel using the SMP framework. It does this by creating a vector of
	/// data objects (the pieces of the composite data) and processing them
	/// using vtkSMPTools::For. Note that this requires that the
	/// algorithm implement all pipeline passes in a re-entrant way. It should
	/// store/retrieve all state changes using input and output information
	/// objects, which are unique to each thread.
	/// </remarks>
	// Token: 0x020009E6 RID: 2534
	public class vtkThreadedCompositeDataPipeline : vtkCompositeDataPipeline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A5FC RID: 108028 RVA: 0x00249D13 File Offset: 0x00247F13
		static vtkThreadedCompositeDataPipeline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreadedCompositeDataPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedCompositeDataPipeline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A5FD RID: 108029 RVA: 0x00249D3B File Offset: 0x00247F3B
		public vtkThreadedCompositeDataPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A5FE RID: 108030
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedCompositeDataPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A5FF RID: 108031 RVA: 0x00249D4C File Offset: 0x00247F4C
		public new static vtkThreadedCompositeDataPipeline New()
		{
			vtkThreadedCompositeDataPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A600 RID: 108032 RVA: 0x00249DA0 File Offset: 0x00247FA0
		public vtkThreadedCompositeDataPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A601 RID: 108033 RVA: 0x00249DE4 File Offset: 0x00247FE4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A602 RID: 108034
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedCompositeDataPipeline_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A603 RID: 108035 RVA: 0x00249DF0 File Offset: 0x00247FF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A604 RID: 108036
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedCompositeDataPipeline_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A605 RID: 108037 RVA: 0x00249E10 File Offset: 0x00248010
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A606 RID: 108038
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedCompositeDataPipeline_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A607 RID: 108039 RVA: 0x00249E2C File Offset: 0x0024802C
		public override int IsA(string type)
		{
			return vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A608 RID: 108040
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedCompositeDataPipeline_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A609 RID: 108041 RVA: 0x00249E4C File Offset: 0x0024804C
		public new static int IsTypeOf(string type)
		{
			return vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_IsTypeOf_04(type);
		}

		// Token: 0x0601A60A RID: 108042
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedCompositeDataPipeline_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A60B RID: 108043 RVA: 0x00249E68 File Offset: 0x00248068
		public new vtkThreadedCompositeDataPipeline NewInstance()
		{
			vtkThreadedCompositeDataPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A60C RID: 108044
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedCompositeDataPipeline_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A60D RID: 108045 RVA: 0x00249EC4 File Offset: 0x002480C4
		public new static vtkThreadedCompositeDataPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkThreadedCompositeDataPipeline vtkThreadedCompositeDataPipeline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedCompositeDataPipeline.vtkThreadedCompositeDataPipeline_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadedCompositeDataPipeline = (vtkThreadedCompositeDataPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadedCompositeDataPipeline.Register(null);
				}
			}
			return vtkThreadedCompositeDataPipeline;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C9C RID: 7324
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedCompositeDataPipeline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C9D RID: 7325
		public new static readonly string MRClassNameKey = "class vtkThreadedCompositeDataPipeline";
	}
}
