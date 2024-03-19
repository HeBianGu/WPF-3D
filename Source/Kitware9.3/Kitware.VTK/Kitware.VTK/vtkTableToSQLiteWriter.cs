using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTableToSQLiteWriter
	/// </summary>
	/// <remarks>
	///    store a vtkTable in an SQLite database
	///
	/// vtkTableToSQLiteWriter reads a vtkTable and inserts it into an SQLite
	/// database.
	/// </remarks>
	// Token: 0x02000274 RID: 628
	public class vtkTableToSQLiteWriter : vtkTableToDatabaseWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600725F RID: 29279 RVA: 0x000A511E File Offset: 0x000A331E
		static vtkTableToSQLiteWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToSQLiteWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToSQLiteWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007260 RID: 29280 RVA: 0x000A5146 File Offset: 0x000A3346
		public vtkTableToSQLiteWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007261 RID: 29281
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSQLiteWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007262 RID: 29282 RVA: 0x000A5154 File Offset: 0x000A3354
		public new static vtkTableToSQLiteWriter New()
		{
			vtkTableToSQLiteWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToSQLiteWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007263 RID: 29283 RVA: 0x000A51A8 File Offset: 0x000A33A8
		public vtkTableToSQLiteWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007264 RID: 29284 RVA: 0x000A51EC File Offset: 0x000A33EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007265 RID: 29285
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSQLiteWriter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06007266 RID: 29286 RVA: 0x000A51F8 File Offset: 0x000A33F8
		public new vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06007267 RID: 29287
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSQLiteWriter_GetInput_02(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input to this writer.
		/// </summary>
		// Token: 0x06007268 RID: 29288 RVA: 0x000A5268 File Offset: 0x000A3468
		public new vtkTable GetInput(int port)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_GetInput_02(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06007269 RID: 29289
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToSQLiteWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600726A RID: 29290 RVA: 0x000A52D8 File Offset: 0x000A34D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600726B RID: 29291
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTableToSQLiteWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600726C RID: 29292 RVA: 0x000A52F8 File Offset: 0x000A34F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600726D RID: 29293
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToSQLiteWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600726E RID: 29294 RVA: 0x000A5314 File Offset: 0x000A3514
		public override int IsA(string type)
		{
			return vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600726F RID: 29295
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTableToSQLiteWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007270 RID: 29296 RVA: 0x000A5334 File Offset: 0x000A3534
		public new static int IsTypeOf(string type)
		{
			return vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_IsTypeOf_06(type);
		}

		// Token: 0x06007271 RID: 29297
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSQLiteWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007272 RID: 29298 RVA: 0x000A5350 File Offset: 0x000A3550
		public new vtkTableToSQLiteWriter NewInstance()
		{
			vtkTableToSQLiteWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToSQLiteWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007273 RID: 29299
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTableToSQLiteWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007274 RID: 29300 RVA: 0x000A53AC File Offset: 0x000A35AC
		public new static vtkTableToSQLiteWriter SafeDownCast(vtkObjectBase o)
		{
			vtkTableToSQLiteWriter vtkTableToSQLiteWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTableToSQLiteWriter.vtkTableToSQLiteWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToSQLiteWriter = (vtkTableToSQLiteWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToSQLiteWriter.Register(null);
				}
			}
			return vtkTableToSQLiteWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F6 RID: 2550
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToSQLiteWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F7 RID: 2551
		public new static readonly string MRClassNameKey = "class vtkTableToSQLiteWriter";
	}
}
