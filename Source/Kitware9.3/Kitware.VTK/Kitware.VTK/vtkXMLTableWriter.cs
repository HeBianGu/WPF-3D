using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLTableWriter
	/// </summary>
	/// <remarks>
	///    Write VTK XML Table files.
	///
	/// vtkXMLTableWriter provides a functionality for writing vtTable as
	/// XML .vtt files.
	/// </remarks>
	// Token: 0x020006E8 RID: 1768
	public class vtkXMLTableWriter : vtkXMLWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012A81 RID: 76417 RVA: 0x001A3B60 File Offset: 0x001A1D60
		static vtkXMLTableWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLTableWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLTableWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012A82 RID: 76418 RVA: 0x001A3B88 File Offset: 0x001A1D88
		public vtkXMLTableWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012A83 RID: 76419
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A84 RID: 76420 RVA: 0x001A3B98 File Offset: 0x001A1D98
		public new static vtkXMLTableWriter New()
		{
			vtkXMLTableWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableWriter.vtkXMLTableWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTableWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A85 RID: 76421 RVA: 0x001A3BEC File Offset: 0x001A1DEC
		public vtkXMLTableWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLTableWriter.vtkXMLTableWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012A86 RID: 76422 RVA: 0x001A3C30 File Offset: 0x001A1E30
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012A87 RID: 76423
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTableWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A88 RID: 76424 RVA: 0x001A3C3C File Offset: 0x001A1E3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLTableWriter.vtkXMLTableWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012A89 RID: 76425
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLTableWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A8A RID: 76426 RVA: 0x001A3C5C File Offset: 0x001A1E5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLTableWriter.vtkXMLTableWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012A8B RID: 76427
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTableWriter_GetNumberOfPieces_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of pieces used to stream the table through the
		/// pipeline while writing to the file.
		/// </summary>
		// Token: 0x06012A8C RID: 76428 RVA: 0x001A3C78 File Offset: 0x001A1E78
		public virtual int GetNumberOfPieces()
		{
			return vtkXMLTableWriter.vtkXMLTableWriter_GetNumberOfPieces_03(base.GetCppThis());
		}

		// Token: 0x06012A8D RID: 76429
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTableWriter_GetWritePiece_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the piece to write to the file.  If this is
		/// negative or equal to the NumberOfPieces, all pieces will be written.
		/// </summary>
		// Token: 0x06012A8E RID: 76430 RVA: 0x001A3C98 File Offset: 0x001A1E98
		public virtual int GetWritePiece()
		{
			return vtkXMLTableWriter.vtkXMLTableWriter_GetWritePiece_04(base.GetCppThis());
		}

		// Token: 0x06012A8F RID: 76431
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTableWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A90 RID: 76432 RVA: 0x001A3CB8 File Offset: 0x001A1EB8
		public override int IsA(string type)
		{
			return vtkXMLTableWriter.vtkXMLTableWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012A91 RID: 76433
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLTableWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A92 RID: 76434 RVA: 0x001A3CD8 File Offset: 0x001A1ED8
		public new static int IsTypeOf(string type)
		{
			return vtkXMLTableWriter.vtkXMLTableWriter_IsTypeOf_06(type);
		}

		// Token: 0x06012A93 RID: 76435
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A94 RID: 76436 RVA: 0x001A3CF4 File Offset: 0x001A1EF4
		public new vtkXMLTableWriter NewInstance()
		{
			vtkXMLTableWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableWriter.vtkXMLTableWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLTableWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012A95 RID: 76437
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLTableWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A96 RID: 76438 RVA: 0x001A3D50 File Offset: 0x001A1F50
		public new static vtkXMLTableWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLTableWriter vtkXMLTableWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLTableWriter.vtkXMLTableWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLTableWriter = (vtkXMLTableWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLTableWriter.Register(null);
				}
			}
			return vtkXMLTableWriter;
		}

		// Token: 0x06012A97 RID: 76439
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTableWriter_SetNumberOfPieces_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of pieces used to stream the table through the
		/// pipeline while writing to the file.
		/// </summary>
		// Token: 0x06012A98 RID: 76440 RVA: 0x001A3DCF File Offset: 0x001A1FCF
		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLTableWriter.vtkXMLTableWriter_SetNumberOfPieces_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06012A99 RID: 76441
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXMLTableWriter_SetWritePiece_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the piece to write to the file.  If this is
		/// negative or equal to the NumberOfPieces, all pieces will be written.
		/// </summary>
		// Token: 0x06012A9A RID: 76442 RVA: 0x001A3DDF File Offset: 0x001A1FDF
		public virtual void SetWritePiece(int _arg)
		{
			vtkXMLTableWriter.vtkXMLTableWriter_SetWritePiece_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001581 RID: 5505
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLTableWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001582 RID: 5506
		public new static readonly string MRClassNameKey = "class vtkXMLTableWriter";
	}
}
