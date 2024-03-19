using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageImportExecutive
	///
	/// vtkImageImportExecutive
	/// </summary>
	// Token: 0x02000785 RID: 1925
	public class vtkImageImportExecutive : vtkStreamingDemandDrivenPipeline
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013C76 RID: 81014 RVA: 0x001BF245 File Offset: 0x001BD445
		static vtkImageImportExecutive()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageImportExecutive.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageImportExecutive"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013C77 RID: 81015 RVA: 0x001BF26D File Offset: 0x001BD46D
		public vtkImageImportExecutive(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013C78 RID: 81016
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImportExecutive_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C79 RID: 81017 RVA: 0x001BF27C File Offset: 0x001BD47C
		public new static vtkImageImportExecutive New()
		{
			vtkImageImportExecutive result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageImportExecutive.vtkImageImportExecutive_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImportExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C7A RID: 81018 RVA: 0x001BF2D0 File Offset: 0x001BD4D0
		public vtkImageImportExecutive() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageImportExecutive.vtkImageImportExecutive_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013C7B RID: 81019 RVA: 0x001BF314 File Offset: 0x001BD514
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013C7C RID: 81020
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageImportExecutive_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C7D RID: 81021 RVA: 0x001BF320 File Offset: 0x001BD520
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageImportExecutive.vtkImageImportExecutive_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013C7E RID: 81022
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageImportExecutive_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C7F RID: 81023 RVA: 0x001BF340 File Offset: 0x001BD540
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageImportExecutive.vtkImageImportExecutive_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06013C80 RID: 81024
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageImportExecutive_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C81 RID: 81025 RVA: 0x001BF35C File Offset: 0x001BD55C
		public override int IsA(string type)
		{
			return vtkImageImportExecutive.vtkImageImportExecutive_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06013C82 RID: 81026
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageImportExecutive_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C83 RID: 81027 RVA: 0x001BF37C File Offset: 0x001BD57C
		public new static int IsTypeOf(string type)
		{
			return vtkImageImportExecutive.vtkImageImportExecutive_IsTypeOf_04(type);
		}

		// Token: 0x06013C84 RID: 81028
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImportExecutive_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C85 RID: 81029 RVA: 0x001BF398 File Offset: 0x001BD598
		public new vtkImageImportExecutive NewInstance()
		{
			vtkImageImportExecutive result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageImportExecutive.vtkImageImportExecutive_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageImportExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013C86 RID: 81030
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageImportExecutive_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013C87 RID: 81031 RVA: 0x001BF3F4 File Offset: 0x001BD5F4
		public new static vtkImageImportExecutive SafeDownCast(vtkObjectBase o)
		{
			vtkImageImportExecutive vtkImageImportExecutive = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageImportExecutive.vtkImageImportExecutive_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageImportExecutive = (vtkImageImportExecutive)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageImportExecutive.Register(null);
				}
			}
			return vtkImageImportExecutive;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016BC RID: 5820
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageImportExecutive";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016BD RID: 5821
		public new static readonly string MRClassNameKey = "class vtkImageImportExecutive";
	}
}
