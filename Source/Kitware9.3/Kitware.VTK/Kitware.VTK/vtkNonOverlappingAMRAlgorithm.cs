using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNonOverlappingAMRAlgorithm
	///  produce vtkNonOverlappingAMR as output.
	///
	///
	///
	/// </summary>
	// Token: 0x020009EB RID: 2539
	public class vtkNonOverlappingAMRAlgorithm : vtkUniformGridAMRAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A678 RID: 108152 RVA: 0x0024A9FB File Offset: 0x00248BFB
		static vtkNonOverlappingAMRAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNonOverlappingAMRAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNonOverlappingAMRAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A679 RID: 108153 RVA: 0x0024AA23 File Offset: 0x00248C23
		public vtkNonOverlappingAMRAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A67A RID: 108154
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMRAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A67B RID: 108155 RVA: 0x0024AA34 File Offset: 0x00248C34
		public new static vtkNonOverlappingAMRAlgorithm New()
		{
			vtkNonOverlappingAMRAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A67C RID: 108156 RVA: 0x0024AA88 File Offset: 0x00248C88
		public vtkNonOverlappingAMRAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A67D RID: 108157 RVA: 0x0024AACC File Offset: 0x00248CCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A67E RID: 108158
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A67F RID: 108159 RVA: 0x0024AAD8 File Offset: 0x00248CD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A680 RID: 108160
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNonOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A681 RID: 108161 RVA: 0x0024AAF8 File Offset: 0x00248CF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A682 RID: 108162
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMRAlgorithm_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm
		/// </summary>
		// Token: 0x0601A683 RID: 108163 RVA: 0x0024AB14 File Offset: 0x00248D14
		public new vtkNonOverlappingAMR GetOutput()
		{
			vtkNonOverlappingAMR vtkNonOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonOverlappingAMR = (vtkNonOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonOverlappingAMR.Register(null);
				}
			}
			return vtkNonOverlappingAMR;
		}

		// Token: 0x0601A684 RID: 108164
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMRAlgorithm_GetOutput_04(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm
		/// </summary>
		// Token: 0x0601A685 RID: 108165 RVA: 0x0024AB84 File Offset: 0x00248D84
		public new vtkNonOverlappingAMR GetOutput(int arg0)
		{
			vtkNonOverlappingAMR vtkNonOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_GetOutput_04(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonOverlappingAMR = (vtkNonOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonOverlappingAMR.Register(null);
				}
			}
			return vtkNonOverlappingAMR;
		}

		// Token: 0x0601A686 RID: 108166
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonOverlappingAMRAlgorithm_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A687 RID: 108167 RVA: 0x0024ABF4 File Offset: 0x00248DF4
		public override int IsA(string type)
		{
			return vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A688 RID: 108168
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNonOverlappingAMRAlgorithm_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A689 RID: 108169 RVA: 0x0024AC14 File Offset: 0x00248E14
		public new static int IsTypeOf(string type)
		{
			return vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_IsTypeOf_06(type);
		}

		// Token: 0x0601A68A RID: 108170
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMRAlgorithm_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A68B RID: 108171 RVA: 0x0024AC30 File Offset: 0x00248E30
		public new vtkNonOverlappingAMRAlgorithm NewInstance()
		{
			vtkNonOverlappingAMRAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A68C RID: 108172
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNonOverlappingAMRAlgorithm_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A68D RID: 108173 RVA: 0x0024AC8C File Offset: 0x00248E8C
		public new static vtkNonOverlappingAMRAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkNonOverlappingAMRAlgorithm vtkNonOverlappingAMRAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNonOverlappingAMRAlgorithm.vtkNonOverlappingAMRAlgorithm_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonOverlappingAMRAlgorithm = (vtkNonOverlappingAMRAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonOverlappingAMRAlgorithm.Register(null);
				}
			}
			return vtkNonOverlappingAMRAlgorithm;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA6 RID: 7334
		public new const string MRFullTypeName = "Kitware.VTK.vtkNonOverlappingAMRAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA7 RID: 7335
		public new static readonly string MRClassNameKey = "class vtkNonOverlappingAMRAlgorithm";
	}
}
