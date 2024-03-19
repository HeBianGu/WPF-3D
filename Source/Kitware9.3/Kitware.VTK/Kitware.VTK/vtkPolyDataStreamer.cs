using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataStreamer
	/// </summary>
	/// <remarks>
	///    Streamer appends input pieces to the output.
	///
	/// vtkPolyDataStreamer initiates streaming by requesting pieces from its
	/// single input it appends these pieces to the requested output.
	/// Note that since vtkPolyDataStreamer uses an append filter, all the
	/// polygons generated have to be kept in memory before rendering. If
	/// these do not fit in the memory, it is possible to make the vtkPolyDataMapper
	/// stream. Since the mapper will render each piece separately, all the
	/// polygons do not have to stored in memory.
	/// @attention
	/// The output may be slightly different if the pipeline does not handle
	/// ghost cells properly (i.e. you might see seames between the pieces).
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendFilter
	/// </seealso>
	// Token: 0x020008CB RID: 2251
	public class vtkPolyDataStreamer : vtkStreamerBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017425 RID: 95269 RVA: 0x0020A93B File Offset: 0x00208B3B
		static vtkPolyDataStreamer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataStreamer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017426 RID: 95270 RVA: 0x0020A963 File Offset: 0x00208B63
		public vtkPolyDataStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017427 RID: 95271
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017428 RID: 95272 RVA: 0x0020A974 File Offset: 0x00208B74
		public new static vtkPolyDataStreamer New()
		{
			vtkPolyDataStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataStreamer.vtkPolyDataStreamer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017429 RID: 95273 RVA: 0x0020A9C8 File Offset: 0x00208BC8
		public vtkPolyDataStreamer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataStreamer.vtkPolyDataStreamer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601742A RID: 95274 RVA: 0x0020AA0C File Offset: 0x00208C0C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601742B RID: 95275
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataStreamer_ColorByPieceOff_01(HandleRef pThis);

		/// <summary>
		/// By default, this option is off.  When it is on, cell scalars are generated
		/// based on which piece they are in.
		/// </summary>
		// Token: 0x0601742C RID: 95276 RVA: 0x0020AA17 File Offset: 0x00208C17
		public virtual void ColorByPieceOff()
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_ColorByPieceOff_01(base.GetCppThis());
		}

		// Token: 0x0601742D RID: 95277
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataStreamer_ColorByPieceOn_02(HandleRef pThis);

		/// <summary>
		/// By default, this option is off.  When it is on, cell scalars are generated
		/// based on which piece they are in.
		/// </summary>
		// Token: 0x0601742E RID: 95278 RVA: 0x0020AA26 File Offset: 0x00208C26
		public virtual void ColorByPieceOn()
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_ColorByPieceOn_02(base.GetCppThis());
		}

		// Token: 0x0601742F RID: 95279
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataStreamer_GetColorByPiece_03(HandleRef pThis);

		/// <summary>
		/// By default, this option is off.  When it is on, cell scalars are generated
		/// based on which piece they are in.
		/// </summary>
		// Token: 0x06017430 RID: 95280 RVA: 0x0020AA38 File Offset: 0x00208C38
		public virtual int GetColorByPiece()
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_GetColorByPiece_03(base.GetCppThis());
		}

		// Token: 0x06017431 RID: 95281
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataStreamer_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017432 RID: 95282 RVA: 0x0020AA58 File Offset: 0x00208C58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06017433 RID: 95283
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataStreamer_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017434 RID: 95284 RVA: 0x0020AA78 File Offset: 0x00208C78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06017435 RID: 95285
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataStreamer_GetNumberOfStreamDivisions_06(HandleRef pThis);

		/// <summary>
		/// Set the number of pieces to divide the problem into.
		/// </summary>
		// Token: 0x06017436 RID: 95286 RVA: 0x0020AA94 File Offset: 0x00208C94
		public int GetNumberOfStreamDivisions()
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_GetNumberOfStreamDivisions_06(base.GetCppThis());
		}

		// Token: 0x06017437 RID: 95287
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataStreamer_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017438 RID: 95288 RVA: 0x0020AAB4 File Offset: 0x00208CB4
		public override int IsA(string type)
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06017439 RID: 95289
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataStreamer_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601743A RID: 95290 RVA: 0x0020AAD4 File Offset: 0x00208CD4
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataStreamer.vtkPolyDataStreamer_IsTypeOf_08(type);
		}

		// Token: 0x0601743B RID: 95291
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataStreamer_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601743C RID: 95292 RVA: 0x0020AAF0 File Offset: 0x00208CF0
		public new vtkPolyDataStreamer NewInstance()
		{
			vtkPolyDataStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataStreamer.vtkPolyDataStreamer_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601743D RID: 95293
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataStreamer_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601743E RID: 95294 RVA: 0x0020AB4C File Offset: 0x00208D4C
		public new static vtkPolyDataStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataStreamer vtkPolyDataStreamer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataStreamer.vtkPolyDataStreamer_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataStreamer = (vtkPolyDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataStreamer.Register(null);
				}
			}
			return vtkPolyDataStreamer;
		}

		// Token: 0x0601743F RID: 95295
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataStreamer_SetColorByPiece_12(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, this option is off.  When it is on, cell scalars are generated
		/// based on which piece they are in.
		/// </summary>
		// Token: 0x06017440 RID: 95296 RVA: 0x0020ABCB File Offset: 0x00208DCB
		public virtual void SetColorByPiece(int _arg)
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_SetColorByPiece_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06017441 RID: 95297
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataStreamer_SetNumberOfStreamDivisions_13(HandleRef pThis, int num);

		/// <summary>
		/// Set the number of pieces to divide the problem into.
		/// </summary>
		// Token: 0x06017442 RID: 95298 RVA: 0x0020ABDB File Offset: 0x00208DDB
		public void SetNumberOfStreamDivisions(int num)
		{
			vtkPolyDataStreamer.vtkPolyDataStreamer_SetNumberOfStreamDivisions_13(base.GetCppThis(), num);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A09 RID: 6665
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataStreamer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A0A RID: 6666
		public new static readonly string MRClassNameKey = "class vtkPolyDataStreamer";
	}
}
