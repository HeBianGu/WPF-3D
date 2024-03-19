using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPImageWriter
	/// </summary>
	/// <remarks>
	///    Writes images to files.
	///
	/// vtkPImageWriter writes images to files with any data type. The data type of
	/// the file is the same scalar type as the input.  The dimensionality
	/// determines whether the data will be written in one or multiple files.
	/// This class is used as the superclass of most image writing classes
	/// such as vtkBMPWriter etc. It supports streaming.
	/// </remarks>
	// Token: 0x0200015F RID: 351
	public class vtkPImageWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060042EA RID: 17130 RVA: 0x00061FA3 File Offset: 0x000601A3
		static vtkPImageWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPImageWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060042EB RID: 17131 RVA: 0x00061FCB File Offset: 0x000601CB
		public vtkPImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060042EC RID: 17132
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042ED RID: 17133 RVA: 0x00061FDC File Offset: 0x000601DC
		public new static vtkPImageWriter New()
		{
			vtkPImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPImageWriter.vtkPImageWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042EE RID: 17134 RVA: 0x00062030 File Offset: 0x00060230
		public vtkPImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPImageWriter.vtkPImageWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060042EF RID: 17135 RVA: 0x00062074 File Offset: 0x00060274
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060042F0 RID: 17136
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPImageWriter_GetMemoryLimit_01(HandleRef pThis);

		/// <summary>
		/// Set / Get the memory limit in kibibytes (1024 bytes). The writer will
		/// stream to attempt to keep the pipeline size within this limit
		/// </summary>
		// Token: 0x060042F1 RID: 17137 RVA: 0x00062080 File Offset: 0x00060280
		public virtual uint GetMemoryLimit()
		{
			return vtkPImageWriter.vtkPImageWriter_GetMemoryLimit_01(base.GetCppThis());
		}

		// Token: 0x060042F2 RID: 17138
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPImageWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042F3 RID: 17139 RVA: 0x000620A0 File Offset: 0x000602A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPImageWriter.vtkPImageWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060042F4 RID: 17140
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPImageWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042F5 RID: 17141 RVA: 0x000620C0 File Offset: 0x000602C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPImageWriter.vtkPImageWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060042F6 RID: 17142
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPImageWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042F7 RID: 17143 RVA: 0x000620DC File Offset: 0x000602DC
		public override int IsA(string type)
		{
			return vtkPImageWriter.vtkPImageWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060042F8 RID: 17144
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPImageWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042F9 RID: 17145 RVA: 0x000620FC File Offset: 0x000602FC
		public new static int IsTypeOf(string type)
		{
			return vtkPImageWriter.vtkPImageWriter_IsTypeOf_05(type);
		}

		// Token: 0x060042FA RID: 17146
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPImageWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042FB RID: 17147 RVA: 0x00062118 File Offset: 0x00060318
		public new vtkPImageWriter NewInstance()
		{
			vtkPImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPImageWriter.vtkPImageWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060042FC RID: 17148
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPImageWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060042FD RID: 17149 RVA: 0x00062174 File Offset: 0x00060374
		public new static vtkPImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPImageWriter vtkPImageWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPImageWriter.vtkPImageWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPImageWriter = (vtkPImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPImageWriter.Register(null);
				}
			}
			return vtkPImageWriter;
		}

		// Token: 0x060042FE RID: 17150
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPImageWriter_SetMemoryLimit_09(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set / Get the memory limit in kibibytes (1024 bytes). The writer will
		/// stream to attempt to keep the pipeline size within this limit
		/// </summary>
		// Token: 0x060042FF RID: 17151 RVA: 0x000621F3 File Offset: 0x000603F3
		public virtual void SetMemoryLimit(uint _arg)
		{
			vtkPImageWriter.vtkPImageWriter_SetMemoryLimit_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000704 RID: 1796
		public new const string MRFullTypeName = "Kitware.VTK.vtkPImageWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000705 RID: 1797
		public new static readonly string MRClassNameKey = "class vtkPImageWriter";
	}
}
