using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCachedStreamingDemandDrivenPipeline
	///
	/// vtkCachedStreamingDemandDrivenPipeline
	/// </summary>
	// Token: 0x020009C8 RID: 2504
	public class vtkCachedStreamingDemandDrivenPipeline : vtkStreamingDemandDrivenPipeline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A258 RID: 107096 RVA: 0x00243BFB File Offset: 0x00241DFB
		static vtkCachedStreamingDemandDrivenPipeline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCachedStreamingDemandDrivenPipeline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCachedStreamingDemandDrivenPipeline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A259 RID: 107097 RVA: 0x00243C23 File Offset: 0x00241E23
		public vtkCachedStreamingDemandDrivenPipeline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A25A RID: 107098
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCachedStreamingDemandDrivenPipeline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A25B RID: 107099 RVA: 0x00243C34 File Offset: 0x00241E34
		public new static vtkCachedStreamingDemandDrivenPipeline New()
		{
			vtkCachedStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachedStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A25C RID: 107100 RVA: 0x00243C88 File Offset: 0x00241E88
		public vtkCachedStreamingDemandDrivenPipeline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A25D RID: 107101 RVA: 0x00243CCC File Offset: 0x00241ECC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A25E RID: 107102
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_GetCacheSize_01(HandleRef pThis);

		/// <summary>
		/// This is the maximum number of images that can be retained in memory.
		/// it defaults to 10.
		/// </summary>
		// Token: 0x0601A25F RID: 107103 RVA: 0x00243CD8 File Offset: 0x00241ED8
		public virtual int GetCacheSize()
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_GetCacheSize_01(base.GetCppThis());
		}

		// Token: 0x0601A260 RID: 107104
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCachedStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A261 RID: 107105 RVA: 0x00243CF8 File Offset: 0x00241EF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A262 RID: 107106
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCachedStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A263 RID: 107107 RVA: 0x00243D18 File Offset: 0x00241F18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A264 RID: 107108
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A265 RID: 107109 RVA: 0x00243D34 File Offset: 0x00241F34
		public override int IsA(string type)
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A266 RID: 107110
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachedStreamingDemandDrivenPipeline_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A267 RID: 107111 RVA: 0x00243D54 File Offset: 0x00241F54
		public new static int IsTypeOf(string type)
		{
			return vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_IsTypeOf_05(type);
		}

		// Token: 0x0601A268 RID: 107112
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCachedStreamingDemandDrivenPipeline_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A269 RID: 107113 RVA: 0x00243D70 File Offset: 0x00241F70
		public new vtkCachedStreamingDemandDrivenPipeline NewInstance()
		{
			vtkCachedStreamingDemandDrivenPipeline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachedStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A26A RID: 107114
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCachedStreamingDemandDrivenPipeline_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A26B RID: 107115 RVA: 0x00243DCC File Offset: 0x00241FCC
		public new static vtkCachedStreamingDemandDrivenPipeline SafeDownCast(vtkObjectBase o)
		{
			vtkCachedStreamingDemandDrivenPipeline vtkCachedStreamingDemandDrivenPipeline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCachedStreamingDemandDrivenPipeline = (vtkCachedStreamingDemandDrivenPipeline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCachedStreamingDemandDrivenPipeline.Register(null);
				}
			}
			return vtkCachedStreamingDemandDrivenPipeline;
		}

		// Token: 0x0601A26C RID: 107116
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCachedStreamingDemandDrivenPipeline_SetCacheSize_09(HandleRef pThis, int size);

		/// <summary>
		/// This is the maximum number of images that can be retained in memory.
		/// it defaults to 10.
		/// </summary>
		// Token: 0x0601A26D RID: 107117 RVA: 0x00243E4B File Offset: 0x0024204B
		public void SetCacheSize(int size)
		{
			vtkCachedStreamingDemandDrivenPipeline.vtkCachedStreamingDemandDrivenPipeline_SetCacheSize_09(base.GetCppThis(), size);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C5D RID: 7261
		public new const string MRFullTypeName = "Kitware.VTK.vtkCachedStreamingDemandDrivenPipeline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C5E RID: 7262
		public new static readonly string MRClassNameKey = "class vtkCachedStreamingDemandDrivenPipeline";
	}
}
